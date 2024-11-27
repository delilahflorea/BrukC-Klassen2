using KlassenGr1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elektronik;


namespace Elektronik
{

    internal class ITGerate : ElektronikAbteilung
    {
        public string GeratTyp { get; set; }
        public int GarantieDauer { get; set; }
        public int SpeicherplatzGB { get; set; }
        //  public string ... { get; set; }



        public ITGerate(string nameeinkaufsladen, string platzierung, string abteilung, int nrangestellte, int kundenanzahltag, float einkommen, int anzahlProdukte, string spezialisiertAuf, Dictionary<string, (decimal Preis, int Menge)> produkte, string geratTyp)
            : base(nameeinkaufsladen, platzierung, abteilung, nrangestellte, kundenanzahltag, einkommen, anzahlProdukte, spezialisiertAuf, produkte)
        {
            GeratTyp = geratTyp;
            GarantieDauer = 36;
            SpeicherplatzGB = 256;
            //  Hersteller = "Generischer Hersteller";
            Console.WriteLine("\nIT-Gerat-typ: " + GeratTyp);
        }


        public override bool offengeschlossen(int uhrzeit)
        {

            return uhrzeit >= 8 && uhrzeit <= 22;
        }

        public void ITGeratInfo()
        {
            Console.WriteLine("\nUnsere Abteilung bietet folgende IT-Geräte für: " + GeratTyp);
        }
    }
}