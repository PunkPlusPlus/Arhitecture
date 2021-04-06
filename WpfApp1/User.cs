using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class User
    {
        public int id { get; set; }
        private string Name, Password, Surname, MidName;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public string surname
        {
            get { return Surname; }
            set { Surname = value; }
        }

        public string midName
        {
            get { return MidName; }
            set { MidName = value; }
        }

        public User() { }

        

        public User(string Name, string Password, string Surname, string MidName)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.MidName = MidName;
            this.Password = Password;
        }

        
    }
}
