using Desktop_PhotoshopOnMin.Exceptions;
using System.Windows;

namespace Desktop_PhotoshopOnMin.Data.SystemOfTrainingImages
{
    public struct Pixel 
    {
        private double r;
        public double R
        {
            get => r;

            set
            {
                if(value > 255 || value < 0)
                {
                    throw new ArgumentRGBException("Не верное зачение для каналов RGB", value);
                }
                else
                {
                    r = value;
                }
            }
        }

        private double g;
        public double G
        {
            get => g;

            set
            {
                if (value > 255 || value < 0)
                {
                    throw new ArgumentRGBException("Не верное зачение для каналов RGB", value);
                }
                else
                {
                    g = value;
                }
            }
        }

        private double b;
        public double B
        {
            get => b;

            set
            {
                if (value > 255 || value < 0)
                {
                    throw new ArgumentRGBException("Не верное зачение для каналов RGB", value);
                }
                else
                {
                    b = value;
                }
            }
        }
    }
}
