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
    // I could use a Singleton here..? I will just be using static methods
    internal class Injects
    {
        public static byte[] nopPayload = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };

        #region Addresses
        // I will be breaking up my pointers based on how close they are in memory.

        /// --------------------------------------
        IntPtr energyCellsAddr;
        IntPtr smithingTokenAddr;
        IntPtr goldenJarAddr;
        /// --------------------------------------

        /// 
        /// --------------------------------------
        IntPtr rerollAddr;
        IntPtr perksAddr;
        /// --------------------------------------

        #endregion

        #region Windows Imports
        // https://learn.microsoft.com/en-us/windows/win32/api/memoryapi/nf-memoryapi-readprocessmemory
        // These method signatures were painful to fix.
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        #endregion

        #region Inject Methods
        // We'll just use a dict to store offsets to our patches


        // This method uses an AOB Injection.. May not be suitable for all Injects.
        // All AOB injections will be done here.
        public static byte[] PatchMemory(IntPtr patchAddr, byte[] payload)
        {
            // We will be returning the restore byte[] to restore our data back to normal
            byte[] restore = new byte[payload.Length];
            int readBytes = 0; // Not really necessary? Could just use null.

            // restore stores the the read bytes.
            bool readSucceed = ReadProcessMemory(WindowsInfo.rqHandle, patchAddr, restore, restore.Length, ref readBytes);
            if (!readSucceed) { return new byte[payload.Length]; }
            WriteProcessMemory(WindowsInfo.rqHandle, patchAddr, payload, payload.Length, ref readBytes);
            return restore;
        }

        public static void PopulateAddresses()
        {

        }
        #endregion
    }
}
