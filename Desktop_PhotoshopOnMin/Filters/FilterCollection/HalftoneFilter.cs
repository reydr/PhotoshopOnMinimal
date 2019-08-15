using Desktop_PhotoshopOnMin.Data.SystemOfTrainingImages;

namespace Desktop_PhotoshopOnMin.Filters.FilterCollection
{
    public class HalftoneFilter : IFilter
    {
        private static HalftoneFilter instance = null;

        public string Name { get; set; }

        private HalftoneFilter()
        {

        }

        public static HalftoneFilter GetInstance()
        {
            if (instance == null)
            {
                instance = new HalftoneFilter();
            }

            return instance;
        }

        public Pixel[,] Filtration(Pixel[,] pixels, uint w, uint h)
        {
            for (uint x = 0; x < w; x++)
            {
                for (uint y = 0; y < h; y++)
                {
                    double convertedPoint = 
                        0.3 * pixels[x, y].R + 
                        0.59 * pixels[x, y].G + 
                        0.11 * pixels[x, y].B;

                    pixels[x, y].R = convertedPoint;
                    pixels[x, y].G = convertedPoint;
                    pixels[x, y].B = convertedPoint;
                }
            }

            return pixels;
        }
    }
}
