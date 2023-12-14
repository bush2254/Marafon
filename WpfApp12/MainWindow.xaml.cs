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

namespace WpfApp12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyFrame.NavigationService.Navigate(new Page10());
            if (MyFrame.Content is Page10)
            {
                Back_1.Visibility = Visibility.Hidden;
            }
            else
            {
                Back_1.Visibility = Visibility.Visible;
            }
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack == true)
            {
                MyFrame.GoBack();
            }
        }
        private void Log(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page10());
        }
    }

  
}

