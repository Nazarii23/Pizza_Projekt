using System.Data.SqlClient;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace Pizzeria
{
    /// <summary>
    /// Interaction logic for Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        DB_PizzeriaEntities DB;

        public Registr()
        {
            InitializeComponent();
            
        }

        private void zalkontoButton_Click_3(object sender, RoutedEventArgs e)
        {
            if (loginField.Text == "")
            {
                MessageBox.Show("Login jest wymagane");
                return;
            }else if (nameField.Text == "")
            {
                MessageBox.Show("Imię jest wymagane");
                return;
            }else if (surnameField.Text == "")
            {
                MessageBox.Show("Nazwisko jest wymagane");
                return;
            }
            else if (hasloField.Password == "")
            {
                MessageBox.Show("Haslo jest wymagane");
                return;
            }
            else
            {
                this.Hide();
                Menu m = new Menu();
                m.Show();
            }

            DB = new DB_PizzeriaEntities();
            Kontakty acc = new Kontakty();
            try
            {
                acc.Login = loginField.Text;
                acc.Imię = nameField.Text;
                acc.Nazwisko = surnameField.Text;
                acc.Haslo = hasloField.Password;
                DB.Kontakties.Add(acc);
                DB.SaveChanges();
            }
            catch (Exception ef)
            {
                
                MessageBox.Show(ef.Message);

            }
        }
    }
}
