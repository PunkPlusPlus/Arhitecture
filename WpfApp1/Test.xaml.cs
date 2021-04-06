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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        public static int num = 0;
        public Test()
        {
            InitializeComponent();
        }

        public void Grid_Loaded(object sender, RoutedEventArgs e)
        {           
            count.Content = num;
        }

        private void Begin2(object sender, RoutedEventArgs e)
        {
            num++;
            frame2.NavigationService.Navigate(new Test2());
        }
    }
}
