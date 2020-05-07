using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_PROJEKT3
{
    class RowerGorski 
    {
        private int _iloscAmortyzatorow;
        private double _dlugoscSztycy;
        private string _firmaHamulceTarczowe;
        
        public RowerGorski(int iloscAmortyzatorow, double dlugoscSztycy, string firmaHamulceTarczowe)
            
        {
            _iloscAmortyzatorow = iloscAmortyzatorow;
            _dlugoscSztycy = dlugoscSztycy;
            _firmaHamulceTarczowe = firmaHamulceTarczowe;
        }
        public int GetiloscAmortyzatorow()
        {
            return _iloscAmortyzatorow;
        }
        public double GetDlugoscSztycy()
        {
            return _dlugoscSztycy;
        }
        public string GetFirmaHamulce()
        {
            return _firmaHamulceTarczowe;
        }

        public override string ToString()
        {
            return  "Ilosc Amortyzatorow: "+_iloscAmortyzatorow + ", Dlugosc Sztycy: " + _dlugoscSztycy + ", Firma od Hamulcy: " + _firmaHamulceTarczowe;
        }
    }
}
