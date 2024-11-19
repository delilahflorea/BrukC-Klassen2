using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Kleidereinkauf : Einkaufsladen
    {
        public string Kleidungstyp { get; set; }
        public bool Sonderangebot { get; set; }

        //Konstruktor 1
        public Kleidereinkauf() : base() { }

        //Konstruktor 2
        public Kleidereinkauf(string nameeinkaufsladen, string platzierung, int kundenanzahltag, string kleidungstyp, bool sonderangebot)
            : base(nameeinkaufsladen, platzierung, kundenanzahltag)
        {
            Kleidungstyp = kleidungstyp;
            Sonderangebot = sonderangebot;
        }

        
        public override bool offengeschlossen(int uhrzeit)
        {
            return uhrzeit >= 9 && uhrzeit < 20; // Öffnungszeiten für Kleidereinkauf
        }

        // Methode 1
        public void Angebot()
        {
            Console.WriteLine( Nameeinkaufsladen );
            Console.WriteLine("Kleidungstyp:" + Kleidungstyp );
            if (Sonderangebot)
            {
                Console.WriteLine("Heute gibt es ein Sonderangebot auf " + Kleidungstyp);
            }
        }

        //Methode 2
        public void VerkaufteKleidung(int anzahl)
        {
            Console.WriteLine(anzahl + " Kleidungsstücke wurden verkauft.");
            Kundenanzahltag += anzahl; // Kundenanzahl erhöhen
        }
        
    }
}

