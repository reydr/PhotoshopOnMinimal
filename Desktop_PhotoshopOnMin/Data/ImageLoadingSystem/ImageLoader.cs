using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Desktop_PhotoshopOnMin.Data.ImageLoadingSystem
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