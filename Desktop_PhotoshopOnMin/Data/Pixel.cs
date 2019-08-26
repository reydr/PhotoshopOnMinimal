using Desktop_PhotoshopOnMin.Exceptions;

namespace Desktop_PhotoshopOnMin.Data
{
    public struct Pixel : System.ICloneable
    {
        private double r;
        public double R
        {
            get => r;

            set
            {
                if (value > 255 || value < 0)
                {
                    throw new ValueRGBException("Не верное зачение для каналов RGB", value);
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
                    throw new ValueRGBException("Не верное зачение для каналов RGB", value);
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
                    throw new ValueRGBException("Не верное зачение для каналов RGB", value);
                }
                else
                {
                    b = value;
                }
            }
        }

        public object Clone()
        {
            return new Pixel { R = this.R, G = this.G, B = this.B };
        }
    }
}
