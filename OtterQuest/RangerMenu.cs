using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtterQuest
{
    public partial class Form2 : Form
    {
        private void setECellsButton_Click(object sender, EventArgs e)
        {

        }

        private void eCellsTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void playerLabel_Click(object sender, EventArgs e)
        {

        }

        private void setECellsButton_Click_2(object sender, EventArgs e)
        {
            Injects.PatchMemory(WindowsInfo.baseAddress + 0x13F62D2, []);
        }
    }
}
