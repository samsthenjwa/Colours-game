
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFResourceStyles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnSolidBrush_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonStyle_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void buttonStyle_Click_1(object sender, RoutedEventArgs e)
        {

            var ShowSolidColorBrush = new WBrushesDisplay();
            ShowSolidColorBrush.Show();
        }

        private void btnSolidBrush_Click_1(object sender, RoutedEventArgs e)
        {
var ShowBrushes = new WUserControlStylesDisplay();
            ShowBrushes.Show();
        }
    }
}

