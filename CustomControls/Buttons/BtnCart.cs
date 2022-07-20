using Ali_Tools;
using CustomControls.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.Buttons
{
    public class BtnCart : Button
    {
        public BtnCart()
        {
            this.Image = ImgResize.resizeImage(Resource.Cart, new Size(50, 50));
            this.Name = "BtnCart";
            this.Text = "Proceed To Cart";
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Tahoma", 12);
        }
    }
}
