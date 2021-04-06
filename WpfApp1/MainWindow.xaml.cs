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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext DB;
        public MainWindow()
        {
            InitializeComponent();
            DB = new AppContext();
            //List<User> users = DB.Users.ToList();
            //string str = "";
            //foreach (User user in users)
            //    str += user.name;

            //test.Content = str;
        }

        private bool CheckInput(string input)
        {
            bool incorrect = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetter(input[i]))
                {
                    incorrect = true;
                }
            }
            return incorrect;
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text.Trim();
            string surname = Surname.Text.Trim();
            string middleName = MiddleName.Text.Trim();
            string password = Pass.Password.Trim();
            bool incorrectName = true;
            bool incorrectSur = true;
            bool incorrectMid = true;
            bool correctPass = true;           
            
            if(CheckInput(name) || name.Length < 2)
            {
                Name.ToolTip = "Не корректный ввод!";
                Name.Background = Brushes.DarkRed;
                Name.Foreground = Brushes.White;
                
            } else { Name.ToolTip = ""; Name.Background = Brushes.White;  Name.Foreground = Brushes.Black; incorrectName = false; }

            if (CheckInput(surname) || surname.Length < 2)
            {
                Surname.ToolTip = "Не корректный ввод!";
                Surname.Background = Brushes.DarkRed;
                Surname.Foreground = Brushes.White;
                
            }
            else { Surname.ToolTip = ""; Surname.Background = Brushes.White;  Surname.Foreground = Brushes.Black; incorrectSur = false; }

            if (CheckInput(middleName) || middleName.Length < 2)
            {
                MiddleName.ToolTip = "Не корректный ввод!";
                MiddleName.Background = Brushes.DarkRed;
                MiddleName.Foreground = Brushes.White;
                
            }
            else { MiddleName.ToolTip = ""; MiddleName.Background = Brushes.White;  MiddleName.Foreground = Brushes.Black; incorrectMid = false; }

            if (password.Length < 4)
            {
                Pass.ToolTip = "Не корректный ввод!";
                Pass.Background = Brushes.DarkRed;
                Pass.Foreground = Brushes.White;
                correctPass = false;
            }
            else { Pass.ToolTip = ""; Pass.Background = Brushes.White; correctPass = true; Pass.Foreground = Brushes.Black; }

            if(!incorrectName && !incorrectSur && !incorrectMid && correctPass)
            {
                //User user = new User(name, surname, middleName, password);
                //DB.Users.Add(user);
                //DB.SaveChanges();

                //LogUsr LogPage = new LogUsr();
                //frame.NavigationService.Navigate(new Uri("LogUsr.xaml", UriKind.Relative));
                frame.NavigationService.Navigate(new LogUsr(name, surname, middleName));
            }
            
            
        }
    }
}
