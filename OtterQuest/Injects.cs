﻿using System;
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
        public static byte[] rangerFocusPayload = {0xC7, 0x87, 0xBC, 0x8C, 0x00, 0x00, 00, 00, 00, 00};

        // We'll just use a dict to store offsets to our patches
        public enum OffsetName { ENERGYCELL, GOLDENJAR, REROLL, PERK, SMITHTOKEN }
        public static Dictionary<OffsetName, (int initialOffset, int[] offsetArray)> offsetData = new Dictionary<OffsetName, (int initialOffset, int[] offsetArray)>()
        {
            {OffsetName.ENERGYCELL, (0x0548FF38, [0x100, 0x1588, 0x1E8C, 0xB1C, 0x210, 0x40, 0x3950]) },
            {OffsetName.GOLDENJAR, (0x0548FF38, [0x100, 0x1588, 0x1E8C, 0xB1C, 0x210, 0x40, 0x396C]) },
            {OffsetName.SMITHTOKEN, (0x0548FF38, [0x100, 0x1588, 0x1E8C, 0xB1C, 0x210, 0x40, 0x3968]) },
            {OffsetName.REROLL, (0x0548FF38, [0x100, 0x1588, 0x1E8C, 0xB1C, 0x210, 0x40, 0x2fc8]) },
            {OffsetName.PERK, (0x0548FF38, [0x100, 0x1588, 0x1E8C, 0xB1C, 0x210, 0x40, 0x2fd8]) }
        };
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
            //Debug.WriteLine(readSucceed);
            if (!readSucceed) { return new byte[payload.Length]; }
            WindowsInfo.WriteProcessMemory(WindowsInfo.rqHandle, patchAddr, payload, payload.Length, ref readBytes);
            return restore;
        }

        /* This did not work out for me.
        // Setup Detour / Trampoline / Codecave
        // Get Virtual Memory
        // Determine a location, patch x bytes with jmp + nops
        public static IntPtr DetourASM()
        {
            return WindowsInfo.VirtualAllocEx(WindowsInfo.rqHandle, (IntPtr)null, Injects.rangerFocusPayload.Length, 0x1000, 0x2000);
        }*/


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
