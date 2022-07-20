using CustomControls.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.Buttons
{
    public class BtnInfo : Button
    {
        public BtnInfo()
        {
            this.Image = Resource.Info;
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleRight;
            this.Font = new Font("Tahoma", 12);
        }
    }
}
