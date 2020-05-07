using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_PROJEKT3
{
    class RowerMTB : RowerGorski, IRowerMiejski
    {
        private double _rozmiarOpon;
        private double _waga;
        private bool _uchwyt;
        private double _wagaKola;

        public RowerMTB(int iloscAmortyzatorow, double dlugoscSztycy, string firmaHamulceTarczowe,double rozmiarOpon, double waga,bool uchwyt,double wagaKola)
            : base(iloscAmortyzatorow, dlugoscSztycy, firmaHamulceTarczowe)
        {
            _rozmiarOpon = rozmiarOpon;
            _waga = waga;
            _uchwyt = uchwyt;
            _wagaKola = wagaKola;
        }
        public double GetRozmiarOpon()
        {
            return _rozmiarOpon;
        }

        public double GetWaga()
        {
            return _waga;
        }
        public bool Uchwyt()
        {
            return _uchwyt;
        }
        public double GetWagaKola()
        {
            return _wagaKola;
        }
        public override string ToString()
        {
            return base.ToString() + ", Rozmiar opon " + _rozmiarOpon + ", Waga " + _waga + ", Uchwyt " + _uchwyt + ", wagaKola " + _wagaKola;
        }

        
        
    }
}
