using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.StringTxtBox
{
    public class StringTextBox : TextBox
    {
        public StringTextBox()
        {
            this.BackColor = Color.Yellow;
            this.ForeColor = Color.Black;
            this.TextAlign = HorizontalAlignment.Center;
            this.Font = new Font("B Nazanin", 14);
            this.KeyPress += StringTextBox_KeyPress;
            this.Enter += StringTextBox_Enter;
            this.Leave += StringTextBox_Leave;
        }

        private void StringTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void StringTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void StringTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
