using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Microsoft.Win32;
using Desktop_PhotoshopOnMin.ImageLoadingSystem;

namespace Desktop_PhotoshopOnMin
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult) return;

            string filename = openFileDialog.FileName;

            ImageLoader imageLoader = ImageLoader.GetInstance();
            imageLoader.SetImage(filename);

            ImgMain.Source = imageLoader.Photo;
        }

        private void FilterCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
