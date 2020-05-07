using System;
using System.Collections.Generic;
using System.Text;

namespace MAS_PROJEKT3
{
   public abstract class Pojazd
    {
        protected int idPojazd;
        protected string marka;
        protected string model;
        protected double cena;
        protected DateTime dataProdukcji;

        protected Pojazd(int idPojazd, string marka, string model, double cena, DateTime dataProdukcji)
        {
            this.idPojazd = idPojazd;
            this.marka = marka;
            this.model = model;
            this.cena = cena;
            this.dataProdukcji = dataProdukcji;
        }
       
        public abstract void showAge();

        
        public override string ToString()
        {
            return "idPojazd: " + idPojazd + ", Marka: " + marka + ", Model: " + model + ", cena w tys: " + cena + ", dataProdukcji: " + dataProdukcji.ToShortDateString();
                     
        }
    }
}
