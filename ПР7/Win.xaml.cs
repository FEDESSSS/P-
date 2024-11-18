using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using static ПР7.Win;
using System.Xml.Linq;

namespace ПР7
{
    /// <summary>
    /// Логика взаимодействия для Win.xaml
    /// </summary>
    public partial class Win : Page
    {
        private List<User> result;
        public Win(string name, string surname, string age, string stat)
        {
            InitializeComponent();
            result = new List<User>();
            result.Add(new User(name, surname, age, stat));
            result.Add(new User("Bob", "Riss", "13", "Пользователь"));
            result.Add(new User("Boby", "Pod", "145", "Менеджер"));
            result.Add(new User("Mom", "Dog", "12", "Пользователь"));
            result.Add(new User("Pavel", "Durov", "999", "Администратор"));
            result.Add(new User("John", "Doe", "1", "Администратор"));
            result.Add(new User("Jane", "Smith", "2", "Пользователь"));
            result.Add(new User("Mike", "Jones", "3", "Менеджер"));
            result.Add(new User("Sarah", "Williams", "4", "Пользователь"));
            result.Add(new User("David", "Brown", "5", "Администратор"));
            result.Add(new User("Emily", "Wilson", "6", "Пользователь"));
            result.Add(new User("Daniel", "Moore", "7", "Менеджер"));
            result.Add(new User("Christopher", "Taylor", "8", "Пользователь"));
            result.Add(new User("Melissa", "Anderson", "9", "Администратор"));
            result.Add(new User("Jennifer", "Thomas", "10", "Пользователь"));
            result.Add(new User("Joshua", "Jackson", "11", "Менеджер"));
            result.Add(new User("Amanda", "White", "12", "Пользователь"));
            result.Add(new User("Matthew", "Martin", "13", "Пользователь"));
            result.Add(new User("Ashley", "Robinson", "14", "Менеджер"));
            result.Add(new User("Ryan", "Davis", "15", "Пользователь"));
            result.Add(new User("Elizabeth", "Rodriguez", "16", "Администратор"));
            result.Add(new User("Joseph", "Garcia", "17", "Пользователь"));
            result.Add(new User("Jessica", "Martinez", "18", "Менеджер"));
            result.Add(new User("Kevin", "Hernandez", "19", "Пользователь"));
            result.Add(new User("Laura", "Lopez", "20", "Администратор"));
            Users.ItemsSource = result;

            if (stat == "Менеджер" || stat == "Пользователь") {
                Del.Visibility = Visibility.Hidden;
            }
            else if (stat == "Пользователь") {
                Cre.Visibility = Visibility.Hidden;
            }
        }

        class User
        {
            public User(string Name, string Surname, string Age, string Stat)
            {
                this.Name = Name;
                this.Surname = Surname;
                this.Age = Age;
                this.Stat = Stat;
            }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Age { get; set; }
            public string Stat { get; set; }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (Users.SelectedItem != null)
            {
                User selectedUser = (User)Users.SelectedItem;
                result.Remove(selectedUser);
                Users.ItemsSource = null; 
                Users.ItemsSource = result;
            }
        }
        
    } 
}
