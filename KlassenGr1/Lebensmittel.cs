﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Lebensmittel: Einkaufsladen
    {
        //zusatzliche info
        public string Kategorie { get; set; }

        //konstruktor 1
        public Lebensmittel() : base()
        {
            Kategorie = "Allgemeine Lebensmittel";
        }


        //konstruktor 2 mit parameter
        public Lebensmittel(string nameeinkaufsladen, string platzierung, string abteilung, int nrangestellte, int kundenanzahltag, float einkommen, string kategorie)
            : base(nameeinkaufsladen, platzierung, abteilung, nrangestellte, kundenanzahltag, einkommen)
        {
            Kategorie = kategorie;
        }


        //uberschriebene methode
        public override bool offengeschlossen(int uhrzeit)
        {
            if (uhrzeit >= 6 && uhrzeit <= 22)
                return true;
            else
                return false;
        }

        //methode
        public virtual void ZeigeKategorie()
        {
            Console.WriteLine("Kategorie:"+ Kategorie);
        }
    }
}
