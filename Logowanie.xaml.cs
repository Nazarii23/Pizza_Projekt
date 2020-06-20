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
using System.Windows.Shapes;

namespace Pizzeria
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class logowanie : Window
    {
        public logowanie()
        {
            InitializeComponent();
        }

        private void LoginButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (loginField.Text == "")
            {
                MessageBox.Show("Login jest wymagane");
                return;
            }
            if (hasloField.Password == "")
            {
                MessageBox.Show("Haslo jest wymagane");
                return;
            }
            else
            {
                DB_PizzeriaEntities DBe = new DB_PizzeriaEntities();
                if (loginField.Text != string.Empty || hasloField.Password != String.Empty)
                {
                    try
                    {
                        var kontakt = DBe.Kontakties.FirstOrDefault(a => a.Login.Equals(loginField.Text));
                        if (kontakt != null)
                        {
                            if (kontakt.Haslo.Equals(hasloField.Password))
                            {
                                this.Hide();
                                Menu m = new Menu();
                                m.Show();

                            }
                            else
                            {
                                MessageBox.Show("Twój Login i Haslo nie jest prawidłowe");
                                return;
                            }
                        }
                    }
                    catch (Exception cf)
                    {
                        MessageBox.Show(cf.Message);
                    }



                }
            }
        }

        private void registrButton_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Registr reg = new Registr();
            reg.Show();
        }
    }
}
