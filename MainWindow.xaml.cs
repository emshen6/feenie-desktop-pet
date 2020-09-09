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
using WpfAnimatedGif;

namespace feenie
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int k = 0;
        string num = "";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Complete(object sender, RoutedEventArgs e)
        {
            num = "Images/" + k.ToString() + ".gif";
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(num, UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(img, image);
        }
        private void Change(object sender, RoutedEventArgs e)
        {
            k = (k + 1) % 11;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            if (k%2==0) image.UriSource = new Uri("Images/a.gif", UriKind.Relative);
            else image.UriSource = new Uri("Images/b.gif", UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(img, image);
        }
    }
}
