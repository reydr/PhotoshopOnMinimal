using System.Windows;
using System.Windows.Controls;

using MahApps.Metro.Controls;

using Desktop_PhotoshopOnMin.Data.ImageLoadingSystem;
using Desktop_PhotoshopOnMin.Data.SystemOfTrainingImages;
using Desktop_PhotoshopOnMin.Filters.FilterCollection;

namespace Desktop_PhotoshopOnMin
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemOpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            Picture picture = Picture.GetInstance();

            picture = Converter.BitmapToPhoto(ImageLoader.PullImage());

            picture.positionsOfPixels = HalftoneFilter.GetInstance().
                Filtration(picture.positionsOfPixels, picture.width, picture.height);

            ImgMain.Source = Converter.BitmapToBitmapImage(Converter.PhotoToBitmap(picture));
        }

        private void FilterCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
