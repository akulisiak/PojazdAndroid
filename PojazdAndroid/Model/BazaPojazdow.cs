using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PojazdAndroid.Model
{
    internal static class BazaPojazdow
    {
        public static List<Pojazd> listaPojazdow = new List<Pojazd> {
            new Samochod(4, "Toyota", 2010),
            new Motocykl(true, "Harley-Davidson", 1975),
            new Samochod(2, "Mazda", 2015),
            new Motocykl(false, "Yamaha", 2020),
            new Samochod(2, "Volvo", 2024),
            new Motocykl(false, "BMW", 2021)
        };
    }
}