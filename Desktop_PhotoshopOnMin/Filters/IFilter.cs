using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Desktop_PhotoshopOnMin.Data.SystemOfTrainingImages;

namespace Desktop_PhotoshopOnMin.Filters
{
    public interface IFilter
    {
        string Name { get; set; }

        Pixel[,] Filtration(Pixel[,] pixels, uint w, uint h);     
    }
}
