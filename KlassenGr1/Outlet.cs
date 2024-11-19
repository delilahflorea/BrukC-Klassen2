using KlassenGr1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutletNamespace
{
    internal class Outlet : Einkaufsladen
    {
        private string[] marken; 
        private int[] mengen; 
        private int markenAnzahl;

        
        public Outlet()
        {
            marken = new string[100]; 
            mengen = new int[100];
            markenAnzahl = 0;
        }

        public Outlet(string nameeinkaufsladen, string platzierung, string abteilung, int nrangestellte, int kundenanzahltag, float einkommen)
            : base(nameeinkaufsladen, platzierung, abteilung, nrangestellte, kundenanzahltag, einkommen)
        {
            marken = new string[100];
            mengen = new int[100];
            markenAnzahl = 0;
        }

        public void ProduktHinzufuegen(string marke, int menge)
        {
            for (int i = 0; i < markenAnzahl; i++)
            {
                if (marken[i] == marke)
                {
                    mengen[i] += menge;
                    Console.WriteLine("Menge von " + marke + " erhöht. Neue Menge: " + mengen[i]);
                    return;
                }
            }
            marken[markenAnzahl] = marke;
            mengen[markenAnzahl] = menge;
            markenAnzahl++;
            Console.WriteLine("Marke " + marke + " hinzugefügt mit Menge: " + menge);
        }

        public void ProduktVerkaufen(string marke)
        {
            for (int i = 0; i < markenAnzahl; i++)
            {
                if (marken[i] == marke)
                {
                    if (mengen[i] > 0)
                    {
                        mengen[i]--;
                        Console.WriteLine("Ein Produkt von " + marke + " verkauft. Verbleibende Menge: " + mengen[i]);
                    }
                    else
                    {
                        Console.WriteLine("Marke " + marke + " ist ausverkauft.");
                    }
                    return;
                }
            }
            Console.WriteLine("Marke " + marke + " nicht gefunden.");
        }

        public void ZeigeAlleProdukte()
        {
            Console.WriteLine("Verfügbare Marken im Outlet:");
            for (int i = 0; i < markenAnzahl; i++)
            {
                Console.WriteLine("- " + marken[i] + ": Menge = " + mengen[i]);
            }
        }

        public override bool offengeschlossen(int uhrzeit)
        {
            if (uhrzeit >= 10 && uhrzeit <= 20)
            {
                return true;
            }
            return false;
        }
    }
}