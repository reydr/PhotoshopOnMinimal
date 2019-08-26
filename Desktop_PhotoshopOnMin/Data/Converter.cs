using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;



namespace Desktop_PhotoshopOnMin.Data
{
    public static class Converter
    {
        public static Picture BitmapToPicture(Bitmap bmp)
        {
            Picture picture = new Picture();

            picture.Width = Convert.ToUInt32(bmp.Width);
            picture.Height = Convert.ToUInt32(bmp.Height);

            picture.Pixels = new Pixel[bmp.Width, bmp.Height];

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    var pixel = bmp.GetPixel(x, y);

                    picture.Pixels[x, y].R = pixel.R;
                    picture.Pixels[x, y].G = pixel.G;
                    picture.Pixels[x, y].B = pixel.B;
                }
            }

            return picture;
        }

        public static Bitmap PictureToBitmap(Picture picture)
        {
            Bitmap bmp = new Bitmap(Convert.ToInt32(picture.Width), Convert.ToInt32(picture.Height));

            for (uint x = 0; x < bmp.Width; x++)
            {
                for (uint y = 0; y < bmp.Height; y++)
                {
                    bmp.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.FromArgb(
                        Convert.ToInt32(picture.Pixels[x, y].R),
                        Convert.ToInt32(picture.Pixels[x, y].G),
                        Convert.ToInt32(picture.Pixels[x, y].B)));
                }
            }

            return bmp;
        }

        public static Bitmap BitmapImageToBitmap(BitmapImage bmpImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BitmapEncoder bmpEncoder = new BmpBitmapEncoder();

                bmpEncoder.Frames.Add(BitmapFrame.Create(bmpImage));

                bmpEncoder.Save(memoryStream);

                Bitmap bitmap = new Bitmap(memoryStream);
                return new Bitmap(bitmap);
            }
        }

        public static BitmapImage BitmapToBitmapImage(Bitmap bmp)
        {
            using (var memory = new MemoryStream())
            {
                bmp.Save(memory, ImageFormat.Png);
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
