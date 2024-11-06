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

namespace ProjectStyle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool colorSelected = false;
        private bool sizeSelected = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ChangeImage(string imSneaker)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri($"Images/{imSneaker}", UriKind.Relative);
            bitmap.EndInit();
            mainSneaker.Source = bitmap;
        }
        private void ChangeButtonGray(object sender, RoutedEventArgs e)
        {
            ChangeImage("Gray.png");
            colorSelected = true;
        }

        private void ChangeButtonBlue(object sender, RoutedEventArgs e)
        {
            ChangeImage("Blue.png");
            colorSelected = true;
        }

        private void ChangeButtonBlack(object sender, RoutedEventArgs e)
        {
            ChangeImage("Black.png");
            colorSelected = true;
        }

        private void ButMessage(object sender, RoutedEventArgs e)
        {
            if (!colorSelected && !sizeSelected)
            {
                MessageBox.Show("Пожалуйста, выберите цвет и размер.");
            }
            else if (colorSelected && !sizeSelected)
            {
                MessageBox.Show("Выберите размер.");
            }
            else if (!colorSelected && sizeSelected)
            {
                MessageBox.Show("Выберите цвет.");
            }
            else if (colorSelected && sizeSelected)
            {
                MessageBox.Show("Успешно добавлено в корзину.");
            }
        }
        private void ButtonSize_Click(object sender, RoutedEventArgs e)
        {
            sizeSelected = true;
        }
    }
}
