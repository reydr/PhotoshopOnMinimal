using System.Windows;
using System.Windows.Controls;

using MahApps.Metro.Controls;

using Desktop_PhotoshopOnMin.Date.ImageLoadingSystem;

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
            ImageLoader imageLoader = ImageLoader.GetInstance();
            imageLoader.PullImage();

            ImgMain.Source = imageLoader.Photo;
        }

        private void FilterCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
