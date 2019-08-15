using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;



namespace Desktop_PhotoshopOnMin.Data.SystemOfTrainingImages
{
    public static class Converter
    {
        public static Picture BitmapToPhoto(Bitmap bmp)
        {
            Picture picture = Picture.GetInstance();

            picture.width = Convert.ToUInt32(bmp.Width);
            picture.height = Convert.ToUInt32(bmp.Height);

            picture.positionsOfPixels = new Pixel[bmp.Width, bmp.Height];

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    var pixel = bmp.GetPixel(x, y);

                    picture.positionsOfPixels[x, y].R = pixel.R;
                    picture.positionsOfPixels[x, y].G = pixel.G;
                    picture.positionsOfPixels[x, y].B = pixel.B;
                }
            }

            return picture;
        }

        public static Bitmap PhotoToBitmap(Picture picture)
        {
            Bitmap bmp = new Bitmap(Convert.ToInt32(picture.width), Convert.ToInt32(picture.height));

            for (uint x = 0; x < bmp.Width; x++)
            {
                for (uint y = 0; y < bmp.Height; y++)
                {
                    bmp.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.FromArgb(
                        Convert.ToInt32(picture.positionsOfPixels[x, y].R),
                        Convert.ToInt32(picture.positionsOfPixels[x, y].G),
                        Convert.ToInt32(picture.positionsOfPixels[x, y].B)));
                }
            }

            return bmp;
        }

        public static Bitmap BitmapImageToBitmap(BitmapImage bitmapImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BitmapEncoder bmpEncoder = new BmpBitmapEncoder();

                bmpEncoder.Frames.Add(BitmapFrame.Create(bitmapImage));

                bmpEncoder.Save(memoryStream);

                Bitmap bitmap = new Bitmap(memoryStream);
                return new Bitmap(bitmap);
            }
        }

        public static BitmapImage BitmapToBitmapImage(Bitmap bitmap)
        {
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Png);
                memory.Position = 0;

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();

                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;

                bitmapImage.EndInit();

                bitmapImage.Freeze();

                return bitmapImage;
            }
        }
    }
}
