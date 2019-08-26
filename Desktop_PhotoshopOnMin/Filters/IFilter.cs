using System.Drawing;
using System.Windows.Media.Imaging;

using Desktop_PhotoshopOnMin.Data;



namespace Desktop_PhotoshopOnMin.Filters
{
    public interface IFilter
    {
        string Name { get; }

        Picture Filtration(Picture picture);
    }
}
