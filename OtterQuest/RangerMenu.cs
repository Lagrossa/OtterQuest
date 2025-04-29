using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtterQuest
{
    public partial class RangerMenu : Form
    {
        public RangerMenu()
        {
            InitializeComponent();
            Program.forms.Add(this);
        }

        private void playerLabel_Click(object sender, EventArgs e)
        {

        }

        // This function is a mess, but I'm a bit low on time.
        private IntPtr focusMemAddr = IntPtr.Zero;
        private byte[] byteData;
        private void focusButton_Click(object sender, EventArgs e)
        {
            
            // I was stuck on this for a few hours. I believe that my issue is that VirtualAllocEx is allocating memory that I cannot jump to within the 4 bytes of a given 0xE9 jmp instruction
            // I cannot figure out how to do this in a way that isn't sloppy.
            if (focusMemAddr == IntPtr.Zero)
            {
                // Create new address
                // 0x1000 = MEM_COMMIT, 0x2000 = MEM_RESERVE, 0x40 = PAGE_EXECUTE_READWRITE
                // Due to the reasons mentioned earlier.. I have a hard-coded value.
                focusMemAddr = WindowsInfo.VirtualAllocEx(WindowsInfo.rqHandle, (nint)0x7FF6D02F0000, 10, 0x1000 | 0x2000, 0x40);
                int bytesR = 0;
                WindowsInfo.ReadProcessMemory(WindowsInfo.rqHandle, WindowsInfo.baseAddress + 0x13F62D2, byteData, 8, ref bytesR);
                Debug.WriteLine($"{focusMemAddr.ToString("X")} address of newly allocated memory");
            }
            byte[] payloadCreation = { 0xE9, 00, 00, 00, 00, 0x90, 0x90, 0x90 };

            long srcAddress = (long)IntPtr.Add(WindowsInfo.baseAddress, 0x13F62D2);
            long dstAddress = (long)focusMemAddr;
            int offset = (int)(dstAddress - srcAddress - 5);
            Debug.WriteLine($"{IntPtr.Add(WindowsInfo.baseAddress, 0x13F62D2).ToString("X")} address of base+offset");
            Debug.WriteLine($"{offset.ToString("X")} address offset");
            BitConverter.GetBytes(offset).CopyTo(payloadCreation, 1); 

            Injects.PatchMemory(WindowsInfo.baseAddress + 0x13F62D2, payloadCreation);

            // Jump is created.
            // Same thing, replace 00 with the float to byte conversion from our textbox. 
            byte[] toInsertValue = [0xC7, 0x87, 0xBC, 0x8C, 0x00, 0x00, 00, 00, 00, 00];
            float.TryParse(focusTextbox.Text, out float result);
            BitConverter.GetBytes(result).CopyTo(toInsertValue,6);
            Injects.PatchMemory(focusMemAddr, toInsertValue);

            Injects.PatchMemory(focusMemAddr + 10, [0xE9, 0xCB, 0x62, 0x40, 0x01]);
        }

        private void focusTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
