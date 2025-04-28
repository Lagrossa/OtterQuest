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
        #region Inject Data
        public static byte[] nopPayload = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };

        // We'll just use a dict to store offsets to our patches
        public enum OffsetName { ENERGYCELL, REROLLS }
        public static Dictionary<OffsetName, (int initialOffset, int[] offsetArray)> offsetData = new Dictionary<OffsetName, (int initialOffset, int[] offsetArray)>()
        {
            {OffsetName.ENERGYCELL, (0x0548FF38, [0x100, 0x1588, 0x1E8C, 0xB1C, 0x210, 0x40, 0x3950]) },
            {OffsetName.REROLLS, (0x0548FF38, [0x100, 0x1588, 0x1E8C, 0xB1C, 0x210, 0x40, 0x2fc8]) }



        };
        #endregion

        #region Addresses
        // I will be breaking up my pointers based on how close they are in memory.

        /// --------------------------------------
        static IntPtr energyCellsAddr;
        static IntPtr smithingTokenAddr;
        static IntPtr goldenJarAddr;
        /// --------------------------------------

        /// 
        /// --------------------------------------
        static IntPtr rerollAddr;
        static IntPtr perksAddr;
        /// --------------------------------------

        #endregion

        #region Inject Methods

        // This method uses an AOB Injection.. May not be suitable for all Injects.
        // All AOB injections will be done here.
        public static byte[] PatchMemory(IntPtr patchAddr, byte[] payload)
        {
            // We will be returning the restore byte[] to restore our data back to normal
            byte[] restore = new byte[payload.Length];
            int readBytes = 0; // Not really necessary? Could just use null.

            // restore stores the the read bytes.
            bool readSucceed = WindowsInfo.ReadProcessMemory(WindowsInfo.rqHandle, patchAddr, restore, restore.Length, ref readBytes);
            if (!readSucceed) { return new byte[payload.Length]; }
            WindowsInfo.WriteProcessMemory(WindowsInfo.rqHandle, patchAddr, payload, payload.Length, ref readBytes);
            return restore;
        }
        
        public static void SetData(int amount, OffsetName offsetName)
        {
            (int initialOffset, int[] offsetArray) data = offsetData[offsetName];
            IntPtr addr = WindowsInfo.DerefPtrChain(WindowsInfo.baseAddress, data.initialOffset, data.offsetArray);
            int bytesRead = 0;
            WindowsInfo.WriteProcessMemory(WindowsInfo.rqHandle, addr, BitConverter.GetBytes(amount), sizeof(int), ref bytesRead);
      
        }

        #endregion
    }
}
