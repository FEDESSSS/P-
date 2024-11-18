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

namespace ПР7
{
    /// <summary>
    /// Логика взаимодействия для Au.xaml
    /// </summary>
    public partial class Au : Page
    {
        public Au()
        {
            InitializeComponent();
        }

        private void BTau_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "" || Surname.Text == "" || Age.Text == ""||Stat.Text=="")
            {
                MessageBox.Show("Заполните все поля");
            }
            else 
            {
                string name = Name.Text;
                string surname = Surname.Text;
                string age = Age.Text;
                string stat = Stat.Text;
                this.NavigationService.Navigate(new Win(name, surname, age, stat));
            }
        }
    }
}
