using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_PROJEKT3
{
    abstract class Osoba
    {
        public string _imie;
        public string _nazwisko;
        public int _pesel;

        protected Osoba(string imie, string nazwisko, int pesel)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _pesel = pesel;
        }

        public override string ToString()
        {
            return "Imie "+ _imie + " Naziwsko " +_nazwisko + " Pesel" + _pesel;
        }
    }
}
