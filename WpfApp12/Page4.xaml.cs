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
using Microsoft.Win32;
namespace WpfApp12
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }
        private void Back_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void Foto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.dif;*.bmp";
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage(new Uri(openFileDialog.FileName));
                imageControl.Source = bitmap;
            }
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


        private void viewing(object sender, RoutedEventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;";
            if (f.ShowDialog() == true)
            {
                BitmapImage b = new BitmapImage(new Uri(f.FileName));
                image.Source = b;
            }
        }
    }
}
