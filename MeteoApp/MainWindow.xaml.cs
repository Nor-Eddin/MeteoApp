﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MeteoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Modifi l'image de fond
            headerImg.Source = new BitmapImage(new Uri(@"/orageux.jpg",UriKind.Relative));
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btninfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StackPanel_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}