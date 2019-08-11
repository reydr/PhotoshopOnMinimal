using System;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Desktop_PhotoshopOnMin.Date.ImageLoadingSystem
{
    public class ImageLoader //: INotifyPropertyChanged
    {
        private static ImageLoader instance = null;

        private BitmapImage photo;
        public BitmapImage Photo
        {
            get => photo;

            set
            {
                //OnPropertyChanged("Photo");
                photo = value;
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

        public void PullImage()
        {
            BitmapImage bitmapImage = new BitmapImage(new Uri(OpenFileDialog()));

            Photo = bitmapImage;
        }

        private string OpenFileDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return null;

                return openFileDialog.FileName;
            }
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