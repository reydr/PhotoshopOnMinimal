using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_PhotoshopOnMin.Data;



namespace Desktop_PhotoshopOnMin.Filters
{
    public class OriginalPicture
    {
        private static OriginalPicture instance = null;

        public string Name { get; } = "Без фильтра";

        public Picture Picture { get; set; }

        public static OriginalPicture GetInstance()
        {
            if (instance == null)
            {
                instance = new OriginalPicture();
            }

            return instance;
        }
    }
}
