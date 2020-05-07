using System;
using System.Net.Mail;

namespace MAS_PROJEKT3
{
    class Program
    {
        static void Main(string[] args)
        {

            //dziedziczenie z klasy abstrakcyjnej Pojazd, dziedziczy Samochod oraz Rower - dziedziczenie rozlaczne, //polimorficzne wywłanie metod showAge()
            Pojazd rower1 = new Rower(1, "Cross", "Allmountains", 2, DateTime.Today, 2.0, 5);
            Console.WriteLine(rower1);
            rower1.showAge();
            Pojazd samochod1 = new Samochod(1, "Subaru", "Impreza", 45, DateTime.Now, 5, 6, "PL",30,0);
            Console.WriteLine(samochod1);
            samochod1.showAge();
            //Dziedziczenie Overlapping Obiekt SamochodRodzinny oraz samochodSportowy dziedziczą z klasy samochod, SamochodSportowy moze byc jedoczesie samochodemRodzinnym
            Samochod samochod = new Samochod(2, "Audi", "RS6", 200, DateTime.Today, 6, 12, "G",40,0);
            samochod.CreateSamochodRodzinny(5,true);
            samochod.CreateSamochodSportowy(450, "twarde");
            Console.WriteLine(samochod);
            //Wielodziedziczenie (multi-inheritance) -> zachodzi miedzy obiektami, RowerMiejski , RowerGorski a RowerMTB, RowerMTB dziedziczy z klas RowerMiejski oraz RowerGorski
            //dla uproszczenia implemnatcji RowerMiejski i RowerGorski, nie dziedzą z klasy Rower (tylko żeby jasno pokazać dziedziczenie)
            RowerMiejski rowerMiejski = new RowerMiejski(1.0, 10, true);
            RowerGorski rowerGorski = new RowerGorski(4, 0.4, "Fuji");
            RowerMTB rowerMTB = new RowerMTB(4, 2.0, "costam", 2, 2, true, 2);
            Console.WriteLine(rowerMiejski);
            Console.WriteLine(rowerGorski);
            Console.WriteLine(rowerMTB);

            //Dziedziczenie wielo aspekotwe (multi-aspect) zrelizowane w klasie samochod, ktory "przyjał" atrybuty opcjonalne z pod-klas
            Samochod tesla = new Samochod(3, "Tesla", "Model S", 500, DateTime.Today, 6, 12, "USA", 0, 500);
            Console.WriteLine(tesla);
            Samochod supra = new Samochod(4, "Toyota", "Supra", 340, DateTime.Today, 3, 6, "JP", 35, 0);
            supra.CreateSamochodSportowy(340, "sport");
            Console.WriteLine(supra);

            //Dziedziczenie dynamiczne miedzy klasa Pracownik i Kieroniwk, Praconiwk moze zotac w przylosci kieronikiem
            Osoba o1 = new Kierownik("Adam", "Adamski",1020005019, "HR");
            Osoba o2 = new Pracownik("Michal", "Michalski",102000313, "podKieronik");
            Osoba o3 = new Pracownik(o2, "HR");
            Console.WriteLine(o1);
            Console.WriteLine(o3);















        }
    }
}
