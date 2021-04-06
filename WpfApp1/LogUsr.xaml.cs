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
    /// Логика взаимодействия для LogUsr.xaml
    /// </summary>
    public partial class LogUsr : Page
    {
        public LogUsr()
        {
            InitializeComponent();
        }

        public LogUsr(string name, string surname, string midname)
        {
            InitializeComponent();
            Fio.Content = surname + "  " + name + "  " + midname;
        }

        private void Begin(object sender, RoutedEventArgs e)
        {
            frame2.NavigationService.Navigate(new Test());
        }
    }
}
