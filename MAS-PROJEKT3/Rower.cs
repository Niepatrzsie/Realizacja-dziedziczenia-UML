using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_PROJEKT3
{
    class Rower : Pojazd
    {
        protected double dlugoscRamy;
        protected int iloscPrzerzutek;

        public Rower(int idPojazd, string marka, string model, double cena, DateTime dataProdukcji, double dlugoscRamy, int iloscPrzerzutek) 
            : base(idPojazd, marka, model, cena, dataProdukcji)
        {
            this.dlugoscRamy = dlugoscRamy;
            this.iloscPrzerzutek = iloscPrzerzutek;
        }

        public override void showAge()
        {
            int rok = DateTime.Now.Year;
            int rokProdukcji = dataProdukcji.Year;
            Console.WriteLine("wiek w latach " +(rok - rokProdukcji));
        }

        public override string ToString()
        {
            return base.ToString() +" " + "Dlugsc Ramy: -"+ dlugoscRamy + " IloscPrzezutek: -" + iloscPrzerzutek;
        }
    }
}
