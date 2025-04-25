using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OtterQuest
{
    internal class Injects
    {
        // https://learn.microsoft.com/en-us/windows/win32/api/memoryapi/nf-memoryapi-readprocessmemory
        // These method signatures were painful to fix.
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        // We'll just use a dict to store offsets to our patches

        // This method uses an AOB Injection.. May not be suitable for all Injects.
        // Considering consolidating all AOB injections into a single function..? Maybe spin off a task?
        private readonly static byte[] restoreCellCost = [0x29, 0x91, 0xd0, 0x88, 0x00, 0x00];
        public static void NoCellCost(bool enable)
        {
            // So our formula for the address is the Base Address + Offset
            IntPtr patchAddr = WindowsInfo.baseAddress + 0x13E99FA;
            byte[] buffer = new byte[6];
            int readBytes = 0;

            if(!enable)
            {
                WriteProcessMemory(WindowsInfo.rqHandle, patchAddr, restoreCellCost, restoreCellCost.Length, ref readBytes);
                return;
            }

            //My payload/buffer. Just setting it to 0x90, NOP instructions
            byte[] payload = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };

            // The read isn't really necessary.. I could store the read and restore it
            bool success = ReadProcessMemory(WindowsInfo.rqHandle, patchAddr, buffer, buffer.Length, ref readBytes);
            if (!success) return;
            WriteProcessMemory(WindowsInfo.rqHandle, patchAddr, payload, payload.Length, ref readBytes);
            return;
        }

        // OVERSLASH GENERATION MULTIPLIER
        private readonly static byte[] restoreOverSlash = [ 0x89, 0x86, 0x08, 0x8A, 0x00, 0x00 ];
        public static void InfiniteOverSlash(bool enable)
        {
            IntPtr patchAddr = WindowsInfo.baseAddress + 0x13D855B;
            int readBytes = 0;
            if (!enable)
            {
                WriteProcessMemory(WindowsInfo.rqHandle, patchAddr, restoreOverSlash, restoreOverSlash.Length, ref readBytes);
                return;
            }
            byte[] payload = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            WriteProcessMemory(WindowsInfo.rqHandle, patchAddr, payload, payload.Length, ref readBytes);
        }


    }
}
