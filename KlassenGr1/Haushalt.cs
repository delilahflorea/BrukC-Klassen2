using System;
using System.Collections.Generic;

namespace Elektronik
{
  
    internal class Haushalt : ElektronikAbteilung
    {
        public string HaushaltTyp { get; set; }
        public int GarantieDauer { get; set; }
        public string EnergieEffizienzKlasse { get; set; }
        public string Hersteller { get; set; }

        

        public Haushalt(string nameeinkaufsladen, string platzierung, string abteilung, int nrangestellte, int kundenanzahltag, float einkommen, int anzahlProdukte, string spezialisiertAuf, string haushaltTyp)
            : base(nameeinkaufsladen, platzierung, abteilung, nrangestellte, kundenanzahltag, einkommen, anzahlProdukte, spezialisiertAuf)
        {
            HaushaltTyp = haushaltTyp;
            GarantieDauer = 24;
            EnergieEffizienzKlasse = "A++";
            Hersteller = "Generischer Hersteller";
            Console.WriteLine("\nHaushaltgerate-typ: "+ HaushaltTyp);
        }


        public override bool offengeschlossen(int uhrzeit)
        {

            return uhrzeit >= 9 && uhrzeit <= 19;
        }

        public void HaushaltsProduktInfo()
        {
            Console.WriteLine("\nWillkommen in der Haushaltsabteilung! Diese Abteilung bietet Geräte für: " + HaushaltTyp);
        }
    }
}
