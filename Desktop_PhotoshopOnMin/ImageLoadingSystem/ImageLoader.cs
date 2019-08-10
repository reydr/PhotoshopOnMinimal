using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

namespace Desktop_PhotoshopOnMin.ImageLoadingSystem
{
    public class ImageLoader //: INotifyPropertyChanged
    {
        private static ImageLoader instance = null;

        private BitmapImage photo;

        public BitmapImage Photo
        {
            get => photo;

            private set
            {
                photo = value;
                //OnPropertyChanged("Photo");
            }
        }

        private ImageLoader()
        {

        }

        public static ImageLoader GetInstance()
        {
            if (instance == null)
            {
                instance = new ImageLoader();
            }

            return instance;
        }

        public void SetImage(string filePath)
        {
            BitmapImage bitmapImage = new BitmapImage(new Uri(filePath));

            Photo = bitmapImage;
        }

        //private void Initialization()
        //{

        //}

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName]string prop = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        //}
    }
}
