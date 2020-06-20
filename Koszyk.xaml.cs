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
    public partial class Koszyk : Window
    {
        DB_PizzeriaEntities DBE;

        public static int suma_zamowienia = 0;
        public static int pizPriCount = 0;
        public static int pizMarCount = 0;
        public static int pizSalCount = 0;
        public static int pizCarCount = 0;
        public static int pizChiCount = 0;
        public static int pizDiaCount = 0;
        public Koszyk()
        {
            InitializeComponent();
            Suma.Content = "Suma: " + suma_zamowienia.ToString() + " zł";
            PizSalCount.Content = "x " + pizSalCount.ToString();
            PizPriCount.Content = "x " + pizPriCount.ToString();
            PizMarCount.Content = "x " + pizMarCount.ToString();
            PizDiaCount.Content = "x " + pizDiaCount.ToString();
            PizChiCount.Content = "x " + pizChiCount.ToString();
            PizCarCount.Content = "x " + pizCarCount.ToString();
        }

        private void Usun_Click(object sender, RoutedEventArgs e)
        {
            suma_zamowienia = 0;
            pizPriCount = 0;
            pizMarCount = 0;
            pizSalCount = 0;
            pizCarCount = 0;
            pizChiCount = 0;
            pizDiaCount = 0;
            this.Hide();
        }

        private void Zamow_Click(object sender, RoutedEventArgs e)
        {
            if (AdresName.Text == "" || TelefonName.Text == "")
            {
                MessageBox.Show("Wprowadź wszystkie potrzebne dane!");
            }
            else
            {
                MessageBox.Show("Twoje zamówienie zostało przyjęte!");
            }

            DBE = new DB_PizzeriaEntities();
            Zamówienia ac = new Zamówienia();
            try
            {
                ac.Adres = AdresName.Text;
                ac.Telefon = TelefonName.Text;
                DBE.Zamówienia.Add(ac);
                DBE.SaveChanges();
            }
            catch (Exception ef)
            {

                MessageBox.Show(ef.Message);

            }

        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
