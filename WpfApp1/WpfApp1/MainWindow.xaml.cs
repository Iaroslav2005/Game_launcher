using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isVisible = false;
        public static MainWindow Window; // глобальная переменная для перемещения окна 
        string AppPath = Directory.GetCurrentDirectory();
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                Button button = (Button)sender;
                ScaleTransform scaleTransform = (ScaleTransform)button.RenderTransform;
                DoubleAnimation animation = new DoubleAnimation(0.9, TimeSpan.FromMilliseconds(100));
                scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, animation);
                scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, animation);
            }
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                Button button = (Button)sender;
                ScaleTransform scaleTransform = (ScaleTransform)button.RenderTransform;
                DoubleAnimation animation = new DoubleAnimation(1.0, TimeSpan.FromMilliseconds(100));
                scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, animation);
                scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, animation);
            }
        }




        /*
            private void ToggleMenu_Click(object sender, RoutedEventArgs e)
          {
              if (menu.Visibility == Visibility.Visible)
              {
                  menu.Visibility = Visibility.Collapsed;
              }
              else
              {
                  menu.Visibility = Visibility.Visible;
              }
          }
        */



        private void Button_Click_WOW(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new WOW();
        }

        private void Button_Click_Hs(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Hs();
        }

        private void Button_Click_OW(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new OW();
        }

        private void Button_Click_W3(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new W3();
        }
        private void Button_Click_DIABLO(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new DIABLO();
        }
        private void Button_Click_HOST(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new HOST();
        }
        private void Button_Click_SC2(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new SC2();
        }

        private void Button_Click_SC(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new SC();
        }


        /*
          private void Button_StartAllGames(object sender, RoutedEventArgs e)
          {

              StartWorldOfWarcraft();
              StartHearthstone();
              StartOverwatch();
              StartWarcraft3();
          }
        */


        // класс для перемещения окна

        private void Drag(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                MainWindow.Window.DragMove();
            }
        }


        // класс для закрытия окна
        private void close_Click(object sender, RoutedEventArgs e)
        {
            base.OnClosed(e);
            App.Current.Shutdown();
        }

    }
}
    