using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_PhotoshopOnMin.Date.SystemOfTrainingImages
{
    public static class Converter
    {
        public static Picture BitmapToPhoto(Bitmap bmp)
        {
            Picture picture = new Picture
            {
                width = bmp.Width,
                height = bmp.Height,

                positionsOfPixels = new Pixel[bmp.Width, bmp.Height]
            };

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    var pixel = bmp.GetPixel(x, y);

                    picture.positionsOfPixels[x, y].R = pixel.R / 255;
                    picture.positionsOfPixels[x, y].G = pixel.G / 255;
                    picture.positionsOfPixels[x, y].B = pixel.B / 255;
                }
            }

            return picture;
        }

        public static Bitmap PhotoToBitmap(Picture picture)
        {
            var bmp = new Bitmap(picture.width, picture.height);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(
                        picture.positionsOfPixels[x, y].R,
                        picture.positionsOfPixels[x, y].G,
                        picture.positionsOfPixels[x, y].B));
                }
            }

            return bmp;
        }
    }
}
