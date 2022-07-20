using CustomControls.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.Buttons
{
    public class BtnAdd : Button
    {
        public BtnAdd()
        {
            this.Image = Resource.Add2;
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Tahoma", 12);
        }
    }
}
