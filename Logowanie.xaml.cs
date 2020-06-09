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
                MessageBox.Show("Plese enter your email");
                return;
            }
            if (hasloField.Password == "")
            {
                MessageBox.Show("Plese enter your pass");
                return;
            }
            else
            {
                this.Hide();
                Menu m = new Menu();
                m.Show();
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
