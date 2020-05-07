using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_PROJEKT3
{
    enum SamochodType { Samochod, SamochodRodziny, SamochodSportowy };
    class Samochod : Pojazd
    {
        protected int _iloscDrzwi;
        protected int _iloscBiegow;
        protected string _krajPochdzoenia;
        private SamochodRodzinny _samochodRodzinny;
        private SamochodSportowy _samochodSportowy;
        private Nullable<int> _pojemnoscBaku; //atrybut opcjonalny samochod z silnikiem spalinowym
        private Nullable<int> _iloscKm; //atrybut opcjonalny z silnikiem elektrycznym
        public Samochod(int idPojazd, string marka, string model, double cena, DateTime dataProdukcji, int iloscDrzwi, int iloscBiegow, string krajPochdzoenia,int pojemnoscBaku,int iloscKm) 
            : base(idPojazd,marka,model,cena,dataProdukcji)
        {
            
            _iloscDrzwi = iloscDrzwi;
            _iloscBiegow = iloscBiegow;
            _krajPochdzoenia = krajPochdzoenia;
            if (pojemnoscBaku == 0)
            {
                _iloscKm = iloscKm;
            }
            else
            {
                _pojemnoscBaku = pojemnoscBaku;
            }
        }
        public Nullable<int> GetPojemnoscBaku()
        {
             if(_pojemnoscBaku == null)
            {
                
                return null;
            }
            else
            {
                return _pojemnoscBaku;
            }   
        }
        public Nullable<int> GetIloscKm()
        {
            if(_iloscKm == null)
            {
                return null;
            }
            else
            {
                return _iloscKm;
            }
        }
        public override void showAge()
        {
            int rok = DateTime.Now.Year;
            int rokProdukcji = dataProdukcji.Year;
            Console.WriteLine("wiek w latach " + (rok - rokProdukcji));
        }
       public void CreateSamochodRodzinny(int iloscMiejsc, bool isofix)
       {
            if (_samochodRodzinny != null)
                return;
            SamochodRodzinny samochodRodzinny = new SamochodRodzinny(iloscMiejsc, isofix);
            _samochodRodzinny = samochodRodzinny;
            
        }
       public void CreateSamochodSportowy(int iloscKoni,string zawieszenie)
       {
            if (_samochodSportowy != null)
                return;
            SamochodSportowy samochodSportowy = new SamochodSportowy(iloscKoni, zawieszenie);
            _samochodSportowy = samochodSportowy;
        
       }
        
        public override string ToString()
        {
            return base.ToString() + " " +" Ilosc Drzwi: " + _iloscDrzwi + ", Ilosc Biegow: " + _iloscBiegow + ", Kraj Pochodzenia: " + _krajPochdzoenia +", Pojemnosc baku: " +_pojemnoscBaku + ", Ilosc Km: "+_iloscKm +" "+_samochodRodzinny + " " +_samochodSportowy;
        }
        private class SamochodRodzinny
        {
            private int _iloscMiejsc;
            private bool _isofix;
            public SamochodRodzinny(int iloscMiejsc, bool isofix)
            {
                _iloscMiejsc = iloscMiejsc;
                _isofix = isofix;
            }

            public override string ToString()
            {
                return "Ilosc Miejsc " +_iloscMiejsc + ", Czy posiada Isofix " + _isofix;
            }
        }
       private class SamochodSportowy
        {
            private int _iloscKoni;
            private string _zawiewszenie;

            public SamochodSportowy(int iloscKoni, string zawiewszenie)
            {
                _iloscKoni = iloscKoni;
                _zawiewszenie = zawiewszenie;
            }

            public override string ToString()
            {
                return ",Ilosc Koni "+_iloscKoni + ", typ zawieszenia " + _zawiewszenie;
            }
        } 
    }
}
