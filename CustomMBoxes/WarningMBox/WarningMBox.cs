using System.Windows.Forms;

namespace CustomMBoxes.InfoMBox
{
    public static class WarningMBox
    {
        public static void ShowMBox(string text, string caption = "Warning")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
    }
}
