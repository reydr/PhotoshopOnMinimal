using System;
using System.Windows;
using System.Windows.Controls;

using MahApps.Metro.Controls;

using Desktop_PhotoshopOnMin.Data;
using Desktop_PhotoshopOnMin.Filters;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Desktop_PhotoshopOnMin
{
    public partial class MainWindow : MetroWindow
    {
        private static MainWindow instance = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_OpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            Picture picture = Converter.BitmapToPicture(ImageLoader.PullImage());
            OriginalPicture originalPicture = OriginalPicture.GetInstance();
            originalPicture.Picture = picture;
            //originalPicture.Picture = picture;

            ImgMain.Source = Converter.BitmapToBitmapImage(Converter.PictureToBitmap(originalPicture.Picture));

            //Надо что-то делать с этими костылем!
            FilterExplorer filterExplorer = FilterExplorer.GetInstance();
            List<BitmapImage> pictures = new List<BitmapImage>(); 
            foreach(Picture i in filterExplorer.Pictures)
            {
                pictures.Add(Converter.BitmapToBitmapImage(Converter.PictureToBitmap(i)));
            }

            ListBox_FilterCollection.ItemsSource = pictures;
        }

        private void ListBox_FilterCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterExplorer filterExplorer = FilterExplorer.GetInstance();

            //ImgMain.Source
        }

        public static MainWindow GetInstance()
        {
            if (instance == null)
            {
                instance = new MainWindow();
            }

            return instance;
        }
    }
}
