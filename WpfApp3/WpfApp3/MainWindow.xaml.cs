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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            m1.Background = Brushes.Blue;
        }

        private void Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            //SB1.Text;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа 'WpfApp3' \nУдачи :)");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            m1.Background = Brushes.Red;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            m1.Background = Brushes.Yellow;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            m1.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            i1.IsEnabled=true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            i1.IsEnabled = false;
            i1.Strokes.Clear();
        }
    }
}
