using KlassenGr1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Elektronik
{
    internal class ElektronikAbteilung : Einkaufsladen
    {
        // Dictionary zur Speicherung von Produkten, Preisen und Beständen
        private Dictionary<string, (decimal Preis, int Menge)> Produkte { get; set; }

        public ElektronikAbteilung()
        {
            Produkte = new Dictionary<string, (decimal Preis, int Menge)>(StringComparer.OrdinalIgnoreCase);
        }

        public ElektronikAbteilung(string nameeinkaufsladen, string platzierung, string abteilung, int nrangestellte, int kundenanzahltag, float einkommen, int anzahlProdukte, string spezialisiertAuf, Dictionary<string, (decimal Preis, int Menge)> produkte)
            : base(nameeinkaufsladen, platzierung, abteilung, nrangestellte, kundenanzahltag, einkommen)
        {
            Console.WriteLine("Willkommen in unserer Elektronikabteilung\n");
            Console.WriteLine($"Die Elektronikabteilung ist Teil des Supermarkts {nameeinkaufsladen}.\n");
            Console.WriteLine($"Die Elektronikabteilung befindet sich in {platzierung}.\n");
            Console.WriteLine($"Die Elektronikabteilung hat {nrangestellte} Mitarbeiter.\n");
            Console.WriteLine($"Die Elektronikabteilung hat {kundenanzahltag} Kunden pro Tag.\n");
            Console.WriteLine($"Die Elektronikabteilung hat ein Einkommen von {einkommen} pro Woche.\n");
            Console.WriteLine($"Die Elektronikabteilung ist spezialisiert auf {spezialisiertAuf}.\n");
            Console.WriteLine($"Die Elektronikabteilung hat {anzahlProdukte} Produkte.\n");
            Produkte = produkte;
        }

        // Methode, um ein Produkt hinzuzufügen oder die Menge zu erhöhen
        public void ProduktHinzufuegen(string produkt, decimal preis, int menge)
        {
            if (Produkte.ContainsKey(produkt))
            {
                Produkte[produkt] = (Produkte[produkt].Preis, Produkte[produkt].Menge + menge);
                Console.WriteLine($"{menge} Einheiten von {produkt} wurden hinzugefügt. Neue Menge: {Produkte[produkt].Menge}.\n");
            }
            else
            {
                Produkte[produkt] = (preis, menge);
                Console.WriteLine($"{produkt} wurde mit einem Preis von {preis:C} und einer Menge von {menge} hinzugefügt.\n");
            }
        }

        // Methode, um ein Produkt zu verkaufen
        public void ProduktVerkaufen(string produkt)
        {
            if (Produkte.ContainsKey(produkt))
            {
                //var produktDetails = Produkte[produkt];
                if (Produkte[produkt].Menge > 0)
                {
                    Produkte[produkt] = (Produkte[produkt].Preis, Produkte[produkt].Menge - 1);
                    Console.WriteLine($"{produkt} wurde verkauft. Verbleibende Menge: {Produkte[produkt].Menge}.\n");
                }

                if (Produkte[produkt].Menge == 0)
                {
                    Produkte.Remove(produkt);
                    Console.WriteLine($"Das Produkt {produkt} ist jetzt ausverkauft und wurde aus dem Bestand entfernt.\n");
                }
            }
            else
            {
                Console.WriteLine($"{produkt} ist nicht vorhanden.\n");
            }
        }

        // Methode, um alle Produkte und deren Details anzuzeigen
        public void ZeigeAlleProdukte()
        {
            Console.WriteLine("Verfügbare Produkte in der Elektronikabteilung:\n");
            foreach (var produkt in Produkte)
            {
                Console.WriteLine($"- {produkt.Key}: Preis = {produkt.Value.Preis:C}, Menge = {produkt.Value.Menge}");
            }
        }

        // Methode, um zu prüfen, ob ein Produkt verfügbar ist
        public bool IstProduktVorhanden(string produkt)
        {
            return Produkte.ContainsKey(produkt);
        }
    }

}

