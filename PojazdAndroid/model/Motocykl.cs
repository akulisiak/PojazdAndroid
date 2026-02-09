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

namespace PojazdAndroid
{
    public class Motocykl : Pojazd
    {
        private bool czyZabytkowy;

        public Motocykl(bool czyZabytkowy, string marka, ushort rokProdukcji) : base(marka, rokProdukcji)
        {
            this.czyZabytkowy = czyZabytkowy;
        }

        public override double ObliczKosztWynajmu(int dni)
        {
            double koszt = (70 * dni);
            if (czyZabytkowy)
            {

                return (koszt * 1.2);
            }
            else
            {
                return koszt;
            }
        }

        public override string Opis()
        {
            string czyZabytek = czyZabytkowy ? "jest" : "nie jest";
            return base.Opis() + $", Motocykl {czyZabytek} zabytkowy";
        }

    }
}