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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }
        private void Regist(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page9());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
        }
    }
}
