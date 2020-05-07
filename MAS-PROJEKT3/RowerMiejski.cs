using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_PROJEKT3
{
    class RowerMiejski : IRowerMiejski
    {
        private double _rozmiarOpon;
        private double _waga;
        private bool _uchwyt;

        public RowerMiejski(double rozmiarOpon,double waga, bool uchwyt)
            
        {
            _rozmiarOpon = rozmiarOpon;
            _waga = waga;
            _uchwyt = uchwyt;
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
        public override string ToString()
        {
            return "Rozmiar Opon w cm: "+_rozmiarOpon + ", Waga: " + _waga + ", Czy posiada uchywt na napoj: " + _uchwyt;
        }

       
    }
}
