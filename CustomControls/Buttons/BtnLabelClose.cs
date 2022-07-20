using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.Buttons
{
    public class BtnLabelClose : Label
    {
        public BtnLabelClose()
        {
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.BackColor = Color.Maroon;
            this.ForeColor = Color.Black;
            this.BorderStyle = BorderStyle.None;
            this.AutoSize = false;
            this.Name = "label1";
            this.Size = new System.Drawing.Size(60, 44);
            this.TabIndex = 0;
            this.Text = "X";
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.MouseEnter += BtnLabelClose_MouseEnter;
            this.MouseLeave += BtnLabelClose_MouseLeave;
        }

        private void BtnLabelClose_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Maroon;
        }

        private void BtnLabelClose_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
