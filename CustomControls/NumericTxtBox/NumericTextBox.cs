using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.NumericTxtBox
{
    public class NumericTextBox : TextBox
    {


        public NumericTextBox()
        {
            this.BackColor = Color.Yellow;
            this.ForeColor = Color.Black;
            this.TextAlign = HorizontalAlignment.Center;
            this.Font = new Font("B Nazanin", 14);
            this.KeyPress += NumericTextBox_KeyPress;
            this.Enter += NumericTextBox_Enter;
            this.Leave += NumericTextBox_Leave;
        }

        private void NumericTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void NumericTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

        }

    }
}
