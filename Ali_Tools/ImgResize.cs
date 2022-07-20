using System.Drawing;

namespace Ali_Tools
{
    public static class ImgResize
    {
        /// <summary>
        /// Resizing and Image .
        /// </summary>
        /// <param name="imgToResize"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }

    }
}
