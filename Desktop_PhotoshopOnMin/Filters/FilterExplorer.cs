using System;
using System.Collections.Generic;

using Desktop_PhotoshopOnMin.Data;



namespace Desktop_PhotoshopOnMin.Filters
{
    public class FilterExplorer
    {
        private static FilterExplorer instance = null;

        private  readonly OriginalPicture originalPicture = OriginalPicture.GetInstance();
        private readonly IFilter halftoneFilter = HalftoneFilter.GetInstance();

        public List<Picture> Pictures { get; private set; } = new List<Picture>();

        private FilterExplorer()
        {
            Initialization();
        }

        public static FilterExplorer GetInstance()
        {
            if (instance == null)
            {
                instance = new FilterExplorer();
            }

            return instance;
        }

        public Picture SelectFilter(uint itemIndex)
        {
            switch (itemIndex)
            {
                case 0:
                    return Pictures[Convert.ToInt32(itemIndex)];
                case 1:
                    return Pictures[Convert.ToInt32(itemIndex)];
                    //break;
                default:
                    return null;
                    //break;
            }
        }
            
        private void Initialization()
        {
            Pictures.Add(originalPicture.Picture);
            Pictures.Add(halftoneFilter.Filtration(originalPicture.Picture));
        }
    }
}    