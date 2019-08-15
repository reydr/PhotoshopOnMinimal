using System;
using System.Drawing;

namespace Desktop_PhotoshopOnMin.Data.SystemOfTrainingImages
{
    public class Picture
    {
        private static Picture instance = null;

        public Bitmap bitmap;

        public uint width;
        public uint height;

        public Pixel[,] positionsOfPixels;

        private Picture()
        {
            //Initialization();
        }

        public static Picture GetInstance()
        {
            if (instance == null)
            {
                instance = new Picture();
            }

            return instance;
        }

        //private void Initialization()
        //{

        //}       
    }
}
