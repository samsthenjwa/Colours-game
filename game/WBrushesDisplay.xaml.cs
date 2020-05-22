
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
using System.Windows.Shapes;

namespace WPFResourceStyles
{
    /// <summary>
    /// Interaction logic for WBrushesDisplay.xaml
    /// </summary>
    public partial class WBrushesDisplay : Window
    {
        public WBrushesDisplay()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle SolidColorBrush will change to Yellow color
            Rectangle1.Width = 100;
            Rectangle1.Height = 110;
            SolidColorBrush brush = new SolidColorBrush(Colors.Yellow);
            Rectangle1.Fill = brush;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle SolidColorBrush will change to Blue color
            Rectangle1.Width = 100;
            Rectangle1.Height = 110;
            SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
            Rectangle1.Fill = brush;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle SolidColorBrush will change to Purple color
            Rectangle1.Width = 100;
            Rectangle1.Height = 110;
            SolidColorBrush brush = new SolidColorBrush(Colors.Purple);
            Rectangle1.Fill = brush;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle LinearGradientBrush will change to PurpleBlue colors
            Rectangle2.Height = 100;
            Rectangle2.Width = 110;

            LinearGradientBrush brush2 = new LinearGradientBrush();
            brush2.GradientStops.Add(new GradientStop(Colors.Blue, 0));
            brush2.GradientStops.Add(new GradientStop(Colors.Purple, 1));
            Rectangle2.Fill = brush2;
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle ImageBrush will change to cherry image
            
            Rectangle4.Fill = (Brush)FindResource("Rectangle4_Bckgrnd");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle LinearGradientBrush will change to PurpleWhite colors
            Rectangle2.Height = 100;
            Rectangle2.Width = 110;

            LinearGradientBrush brush3 = new LinearGradientBrush();
            brush3.GradientStops.Add(new GradientStop(Colors.Purple, 0));
            brush3.GradientStops.Add(new GradientStop(Colors.White, 0.5));
            Rectangle2.Fill = brush3;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle LinearGradientBrush will change to YellowOrangeRed colors
            Rectangle2.Height = 100;
            Rectangle2.Width = 110;

            LinearGradientBrush brush4 = new LinearGradientBrush();
            brush4.GradientStops.Add(new GradientStop(Colors.Yellow, 0));
            brush4.GradientStops.Add(new GradientStop(Colors.Orange, 1));
            brush4.GradientStops.Add(new GradientStop(Colors.Red, 0.5));
            Rectangle2.Fill = brush4;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle RadialGradientBrush will change to BlueWhiteBlack colors
            Rectangle3.Height = 100;
            Rectangle3.Width = 110;

            RadialGradientBrush brush5 = new RadialGradientBrush();
            brush5.GradientStops.Add(new GradientStop(Colors.Blue, 0.5));
            brush5.GradientStops.Add(new GradientStop(Colors.White, 0));
            brush5.GradientStops.Add(new GradientStop(Colors.Black, 1.2));
            Rectangle3.Fill = brush5;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle RadialGradientBrush will change to PurpleWhiteBlack colors
            Rectangle3.Height = 100;
            Rectangle3.Width = 110;

            RadialGradientBrush brush6 = new RadialGradientBrush();
            brush6.GradientStops.Add(new GradientStop(Colors.Purple, 0.5));
            brush6.GradientStops.Add(new GradientStop(Colors.White, 0));
            brush6.GradientStops.Add(new GradientStop(Colors.Black, 1.2));
            Rectangle3.Fill = brush6;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle RadialGradientBrush will change to OrangeWhiteYellowRed colors
            Rectangle3.Height = 100;
            Rectangle3.Width = 110;

            RadialGradientBrush brush7 = new RadialGradientBrush();
            brush7.GradientStops.Add(new GradientStop(Colors.Orange, 0));
            brush7.GradientStops.Add(new GradientStop(Colors.White, 0));
            brush7.GradientStops.Add(new GradientStop(Colors.Yellow, 0.4));
            brush7.GradientStops.Add(new GradientStop(Colors.Red, 1.2));
            Rectangle3.Fill = brush7;
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle ImageBrush will change to four_cherries image
            Rectangle4.Fill = Button11.Background;
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle ImageBrush will change to cher image
            
            Rectangle4.Fill = Button12.Background;
           
        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle RadialGradientBrush will change to BlueBlack colors
            Rectangle5.Width = 100;
            Rectangle5.Height = 110;

            RadialGradientBrush brush15 = new RadialGradientBrush();
            brush15.GradientOrigin = new Point(0.75, 0.25);
            brush15.GradientStops.Add(new GradientStop(Colors.Blue, 0.5));
            brush15.GradientStops.Add(new GradientStop(Colors.Black, 1));

            Rectangle5.Fill = brush15;
        }

        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            //Will change visualBrush of Rectangle6 to Text "Hello World"
            Rectangle6.Width = 100;
            Rectangle6.Height = 110;

            VisualBrush brush16 = new VisualBrush();
            StackPanel stack_text = new StackPanel();
            stack_text.Background = Brushes.White;

            TextBlock brushA = new TextBlock();
            FontSizeConverter size = new FontSizeConverter();
            brushA.FontSize = (double)size.ConvertFrom("10pt");
            brushA.Text = "Hello, World!";
            stack_text.Children.Add(brushA);

            TextBlock brushB = new TextBlock();
            FontSizeConverter size2 = new FontSizeConverter();
            brushB.FontSize = (double)size2.ConvertFrom("10pt");
            brushB.Text = "Hello, World!";
            stack_text.Children.Add(brushB);

            TextBlock brushC = new TextBlock();
            FontSizeConverter size3 = new FontSizeConverter();
            brushC.FontSize = (double)size3.ConvertFrom("10pt");
            brushC.Text = "Hello, World!";
            stack_text.Children.Add(brushC);

            TextBlock brushD = new TextBlock();
            FontSizeConverter size4 = new FontSizeConverter();
            brushD.FontSize = (double)size4.ConvertFrom("10pt");
            brushD.Text = "Hello, World!";
            stack_text.Children.Add(brushD);

            brush16.Visual = stack_text;
            Rectangle6.Fill = brush16;
        }

        private void Button17_Click(object sender, RoutedEventArgs e)
        {
            //Will change visualBrush of Rectangle6 to skew Text "Hello World"
            Rectangle6.Width = 100;
            Rectangle6.Height = 110;

            VisualBrush brush17 = new VisualBrush();
            StackPanel txt = new StackPanel();
            txt.Background = Brushes.White;

            TextBlock text = new TextBlock();
            FontSizeConverter size = new FontSizeConverter();
            text.FontSize = (double)size.ConvertFrom("10pt");
            text.Text = "Hello, World!";
            txt.Children.Add(text);

            TextBlock text1 = new TextBlock();
            FontSizeConverter size2 = new FontSizeConverter();
            text1.FontSize = (double)size2.ConvertFrom("10pt");
            text1.Text = "Hello, World!";
            txt.Children.Add(text1);

            TextBlock text2 = new TextBlock();
            FontSizeConverter size3 = new FontSizeConverter();
            text2.FontSize = (double)size3.ConvertFrom("10pt");
            text2.Text = "Hello, World!";
            txt.Children.Add(text2);

            TextBlock text3 = new TextBlock();
            FontSizeConverter size4 = new FontSizeConverter();
            text3.FontSize = (double)size4.ConvertFrom("10pt");
            text3.Text = "Hello, World!";
            txt.Children.Add(text3);

            TextBlock text4 = new TextBlock();
            FontSizeConverter size5 = new FontSizeConverter();
            text4.FontSize = (double)size5.ConvertFrom("2pt");
            text4.Text = "Hello, World!";
            txt.Children.Add(text4);

            RotateTransform rotate = new RotateTransform();
            rotate.CenterX = 0.5;
            rotate.CenterY = 0.5;
            rotate.Angle = -45;

            brush17.Visual = txt;
            brush17.RelativeTransform = rotate;

            Rectangle6.Fill = brush17;
        }

        private void Button19_Click(object sender, RoutedEventArgs e)
        {
            //Will change VisualBrush of Rectangle6 to skew  Button Text 
            Rectangle6.Width = 100;
            Rectangle6.Height = 110;

            VisualBrush brush18 = new VisualBrush();
            StackPanel button = new StackPanel();
            button.Background = Brushes.White;

            Button btn = new Button();
            btn.Content = "A Button";
            button.Children.Add(btn);

            Button btn2 = new Button();
            btn2.Content = "Another Button";
            button.Children.Add(btn2);

            brush18.Visual = button;
            Rectangle6.Fill = brush18;
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {

            Rectangle5.Fill = Button13.Background;
        }

        private void Button14_Click(object sender, RoutedEventArgs e)
        {

            Rectangle5.Fill = Button14.Background;
        }

        private void Rectangle4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle4.Fill = (Brush)FindResource("Rectangle4_Bckgrnd");
        }

        private void Rectangle5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle5.Fill = (Brush)FindResource("Rectangle5_Bckgrnd");
        }

        private void Rectangle1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle1.Fill = (Brush)FindResource("WrapPanelBackGroundBrush");
        }

        private void Rectangle2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle2.Fill = (Brush)FindResource("Rectangle2_Bckgrnd");
        }

        private void Rectangle3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle3.Fill = (Brush)FindResource("Rectangle3_Bckgrnd");
        }

        private void Rectangle6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle6.Fill = (Brush)FindResource("Rectangle6_Bckgrnd");
        }


    }
}

