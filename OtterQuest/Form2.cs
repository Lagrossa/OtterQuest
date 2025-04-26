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
        public Form2()
        {
            InitializeComponent();
            Program.forms.Add(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infiniteAmmoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cellMem_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.forms[0].Show();
        }

        private void setWrenchesButton_Click(object sender, EventArgs e)
        {
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private byte[] restoreNoCell;
        private void noCellCostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // The first check sets it on.. Restore value is saved. The next check sets it off. It is now in the original state.
            restoreNoCell = Injects.PatchMemory(WindowsInfo.baseAddress + 0x13E99FA, noCellCostCheckBox.Checked ? Injects.nopPayload : restoreNoCell );
        }
    }
}
