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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page8());
        }
        private void Back_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void Button(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void Button_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(t.Text))
            {
                t.Text = t.Tag.ToString();
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == t.Tag.ToString())
            {
                t.Text = "";
            }
        }
        private void plus(object sender, RoutedEventArgs e)
        {
            double R = double.Parse(V.Text);
            if (R < 0 || R >= 100000)
            {
                R = 0;
            }
            R += 10;
            V.Text = $"{R}";
        }

        private void minus(object sender, RoutedEventArgs e)
        {
            double R = double.Parse(V.Text);
            if (R < 0 || R >= 100000)
            {
                R = 0;
            }
            if (R >= 10)
            {
                R -= 10;
            }
            V.Text = $"{R}";
        }
    }
}
