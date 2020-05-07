using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_PROJEKT3
{
    class Pracownik : Osoba
    {
        private string _stanowisko;
        public Pracownik(string imie, string nazwisko, int pesel,string stanowisko) 
            : base(imie, nazwisko, pesel)
        {
            _stanowisko = stanowisko;
        }
        public Pracownik(Osoba osoba, string stanowisko)
             : base(osoba._imie, osoba._nazwisko, osoba._pesel)
        {
            _stanowisko = stanowisko;
        }
        public override string ToString()
        {
            return base.ToString() + " stanowsiko " +_stanowisko;
        }
    }
    
}
