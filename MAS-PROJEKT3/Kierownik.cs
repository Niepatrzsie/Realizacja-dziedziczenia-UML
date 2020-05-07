using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_PROJEKT3
{
    class Kierownik : Osoba
    {
        private string _dzial;

        public Kierownik(string imie, string nazwisko, int pesel, string dzial) :
            base(imie, nazwisko, pesel)
        {
            _dzial = dzial;
        }

        public override string ToString()
        {
            return base.ToString() + " dział " + _dzial;
        }
    }
}
