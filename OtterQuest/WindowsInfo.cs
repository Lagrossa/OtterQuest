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
    // This class manages WinAPI calls and related functions.

    //
    internal class WindowsInfo
    {
        // FORMAT. ProcessName -> PID -> Process -> Handle -> R/W Memory?
        internal static string processName { get; private set; }
        internal static Process? rqProcess { get; private set; }
        internal static IntPtr baseAddress { get; private set; }
        internal static IntPtr rqHandle { get; private set; }

        public static bool PopulateProcess()
        {
            // Maybe allow the user to CHOOSE a process? That might be interesting.
            // But that also opens the door for user error.
            processName = "RoboQuest-Win64-Shipping";

            // Get the Process to manipulate memory.
            Process[] rq = Process.GetProcessesByName(processName);
            if (rq.Length < 1) { Debug.WriteLine("Nothing Found"); return false; }
            rqProcess = rq[0];
            if (rqProcess is null) { return false; }
            return true;
            // Easier than expected!
        }


        #region Windows Imports

        // Regarding the access modifiers of these functions..
        // 

        // https://learn.microsoft.com/en-us/windows/win32/api/memoryapi/nf-memoryapi-readprocessmemory
        // These method signatures were painful to fix.
        [DllImport("kernel32.dll")]
        internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        // Import kernel32's OpenProcess
        // https://learn.microsoft.com/en-us/windows/win32/api/processthreadsapi/nf-processthreadsapi-openprocess
        // This returns a 'IntPtr' so our Handle must match the type.
        [DllImport("kernel32.dll")]
        internal static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        internal static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, uint flAllocationType, uint flProtect);   
        #endregion

        public static bool PopulateHandle()
        {
            // I'm just using PROCESS_ACCESS_ALL.. probably poor design.
            // OpenProcess uses DWORD, which they define as a 32bit unsigned int. We will use uint.

            rqHandle = OpenProcess((uint)0x1F0FFF, false, rqProcess.Id);
            baseAddress = rqProcess.MainModule.BaseAddress;
            return true;
        }

        // This function will be to "Dereference" and sort of evaluate pointer chains.
        // A chain will look like:
        // *(*(*(baseModule + initialOffset) + offsets[0]) + offsets[1]) . . . so on.
        // That is to say, an offset is added to (baseAddr + initialOffset). The bytes at that new location is a pointer.
        // We read the memory of that new pointer and add the next offset. 
        public static IntPtr DerefPtrChain(IntPtr baseAddr, int initialOffset, int[] offsets)
        {
            //Debug.WriteLine($"Base Address is {baseAddr:x}");
            IntPtr address = baseAddr + initialOffset;
            int bytesRead = 0;
            unsafe
            {
                byte[] buffer = new byte[sizeof(IntPtr)];
                foreach (int offset in offsets)
                {
                    //Debug.WriteLine($"{address:x}");
                    ReadProcessMemory(rqHandle, address, buffer, sizeof(IntPtr), ref bytesRead);
                /*  I thought I would have to debug this for hours.. After writing it to the console, all I needed to do differently
                    was convert to Int64 instead of Int32!

                    foreach (byte b in buffer)
                    {
                        Debug.Write($"{b:x}, ");
                    }
                    Debug.WriteLine("");
                    
                    Debug.WriteLine($"New Address? {(IntPtr)BitConverter.ToInt64(buffer):x}");
                */
                    address = (IntPtr)BitConverter.ToInt64(buffer) + offset;                    
                }
                return address;
            }
        }




    }
}
