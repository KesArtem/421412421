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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (t1 != null)
                t2.FontSize = ((Slider)sender).Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            t1.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            t2.Foreground= Brushes.Blue;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void S_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (t1 != null)
                t2.FontSize = ((Slider)sender).Value;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            t2.Foreground = Brushes.Red;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            t2.Foreground = Brushes.Green;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            t2.Foreground = Brushes.Yellow;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            t2.Foreground = Brushes.Black;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            t2.FontFamily =new FontFamily("Times New Roman");
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            t2.FontFamily = new FontFamily("Comic Sans MS");
        }

        private void Button_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }

        private void T1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void T2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
