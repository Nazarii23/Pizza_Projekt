﻿using System;
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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Koszyk : Window
    {
        public static int suma_zamowienia;
        public static Dictionary<string, int> dane = new Dictionary<string, int>() 
        {
            {"Pizza Primavera", 0},
            {"Pizza Diavalo", 0},
            {"Pizza Chiken", 0},
            {"Pizza Carbonara", 0},
            {"Pizza Margherita", 0},
            {"Pizza Salame", 0},
        };
        public Koszyk()
        {
            InitializeComponent();
        }
    }
}
