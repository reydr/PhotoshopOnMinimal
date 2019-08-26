using System.Drawing;
using System.Windows.Forms;

namespace Desktop_PhotoshopOnMin
{
    public static class ImageLoader
    {
        public static Bitmap PullImage()
        {
            Bitmap bitmapImage = new Bitmap(OpenFileDialog());

            return bitmapImage;
        }

        private static string OpenFileDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                return openFileDialog.ShowDialog() == DialogResult.Cancel ? null : openFileDialog.FileName;
            }
        }
    }
}