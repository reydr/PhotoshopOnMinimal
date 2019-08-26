using System.Drawing;
using System.Windows.Media.Imaging;

using Desktop_PhotoshopOnMin.Data;

namespace Desktop_PhotoshopOnMin.Filters
{
    public sealed class HalftoneFilter : IFilter
    {
        private static HalftoneFilter instance = null;

        public string Name { get; } = "Полутоновый фильтр";

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

        public Picture Filtration(Picture originalPicture)
        {
            Picture picture = (Picture)originalPicture.Clone();

            for (uint x = 0; x < picture.Width; x++)
            {
                for (uint y = 0; y < picture.Height; y++)
                {
                    double convertedPoint =
                        0.3 * picture.Pixels[x, y].R
                        + 0.59 * picture.Pixels[x, y].G
                        + 0.11 * picture.Pixels[x, y].B;

                    picture.Pixels[x, y].R = convertedPoint;
                    picture.Pixels[x, y].G = convertedPoint;
                    picture.Pixels[x, y].B = convertedPoint;
                }
            }
        
            return picture;
        }
    }
}
