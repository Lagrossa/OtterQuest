using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

using System.Security;

namespace OtterQuest
{
    internal class WindowsInfo
    {
        // FORMAT. ProcessName -> PID -> Process -> Handle -> R/W Memory?
        internal static string processName = "RoboQuest-Win64-Shipping";
        internal static Process? rqProcess;
        internal static IntPtr baseAddress;
        /*
            So... How did I settle on IntPtr for the handle?

            Initially I used IntPtr, but I swapped to nint as per the recommendation of Visual Studio...

            I knew I needed ReadProcessMemory and WriteProcessMemory,
            but I did not know how to access these functions in C#.
            I found documentation online that used their signature as 'int'. And to satisfy the compiler,
            I had to cast my nint to int. Despite compiling, my code did not work and I struggled to debug
            the issue for hours.

            I will not be using nint in the foreseeable future, IntPtr is more specific and made more sense to
            me anyway...
        */
        internal static IntPtr rqHandle;

        public static bool PopulateProcess()
        {
            // Get the Process to manipulate memory.
            Process[] rq = Process.GetProcessesByName(processName);
            if(rq.Length < 1) { Debug.WriteLine("Nothing Found"); return false; }
            rqProcess = rq[0];
            if (rqProcess is null) { return false; }
            return true;
            // Easier than expected!
        }

        // Import kernel32's OpenProcess
        // https://learn.microsoft.com/en-us/windows/win32/api/processthreadsapi/nf-processthreadsapi-openprocess
        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        // This returns a 'nint' so our Handle must match the type.

        public static bool PopulateHandle()
        {
            // I'm just using PROCESS_ACCESS_ALL.. probably poor design.
            // OpenProcess uses DWORD, which they define as a 32bit unsigned int. We will use uint.

            rqHandle = OpenProcess((uint)0x1F0FFF, false, rqProcess.Id);
            baseAddress = rqProcess.MainModule.BaseAddress;
            return true;
        }
    }
}
