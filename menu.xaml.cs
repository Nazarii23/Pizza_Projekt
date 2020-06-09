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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Pizza Pizza_Primavera;
        public Pizza Pizza_Diavalo;
        public Pizza Pizza_Chiken;
        public Pizza Pizza_Carbonara;
        public Pizza Pizza_Margherita;
        public Pizza Pizza_Salame;
        public Menu()
        {
            InitializeComponent();
            Pizza_Primavera = new Pizza(PizPri.Text, PizPriDes.Text, 30);
            Pizza_Diavalo = new Pizza(PizDia.Text, PizDiaDes.Text, 45);
            Pizza_Chiken = new Pizza(PizChi.Text, PizChiDes.Text, 60);
            Pizza_Carbonara = new Pizza(PizCar.Text, PizCarDes.Text, 35);
            Pizza_Margherita = new Pizza(PizMar.Text, PizMarDes.Text, 20);
            Pizza_Salame = new Pizza(PizSal.Text, PizSalDes.Text, 40);
        }

        private void dodajPizzeClick(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;
            switch (but.Name)
            {
                case "PizPri_Button":
                    Koszyk.suma_zamowienia += Pizza_Primavera.PizzaCost;
                    Koszyk.dane["Pizza Primavera"] += 1;
                    break;
                case "PizDia_Button":
                    Koszyk.suma_zamowienia += Pizza_Diavalo.PizzaCost;
                    Koszyk.dane["Pizza Diavalo"] += 1;
                    break;
                case "PizChi_Button":
                    Koszyk.suma_zamowienia += Pizza_Chiken.PizzaCost;
                    Koszyk.dane["Pizza Chiken"] += 1;
                    break;
                case "PizCar_Button":
                    Koszyk.suma_zamowienia += Pizza_Carbonara.PizzaCost;
                    Koszyk.dane["Pizza Carbonara"] += 1;
                    break;
                case "PizMar_Button":
                    Koszyk.suma_zamowienia += Pizza_Margherita.PizzaCost;
                    Koszyk.dane["Pizza Margherita"] += 1;
                    break;
                case "PizSal_Button":
                    Koszyk.suma_zamowienia += Pizza_Salame.PizzaCost;
                    Koszyk.dane["Pizza Salame"] += 1;
                    break;
            }
        }
    }
}
