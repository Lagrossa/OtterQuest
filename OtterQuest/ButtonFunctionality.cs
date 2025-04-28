using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtterQuest
{
    internal static class ButtonFunctionality
    {
        internal static void ButtonSetValues(TextBox textBox, Injects.OffsetName offsetName)
        {
            Int32.TryParse(textBox.Text, out int amt);
            Injects.SetData(Math.Min(amt, 9999), offsetName);
            textBox.Text = ""; // Clear text box when done.
        }
    }
}
