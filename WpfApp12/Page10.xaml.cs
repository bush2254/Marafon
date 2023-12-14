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
    /// Логика взаимодействия для Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        public Page10()
        {
            InitializeComponent();
        }
        private void Regist(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void Login(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }
        private void Sponsor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page7());
        }
        private void Read(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }
    }
}
