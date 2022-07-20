using System.Windows.Forms;

namespace CustomMBoxes.InfoMBox
{
    public static class InfoMBox
    {
        public static void ShowMBox(string text, string caption = "Information")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
