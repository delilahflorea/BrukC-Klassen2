using System;

namespace KlassenGr1
{
    internal class Vegetarisch : Lebensmittel
    {
        public int AnzahlVegetarischeProdukte { get; set; }

        public Vegetarisch() : base()
        {
            AnzahlVegetarischeProdukte = 0;
        }

        public Vegetarisch(string nameeinkaufsladen, string platzierung, string abteilung, int nrangestellte, int kundenanzahltag, float einkommen, string kategorie, int anzahlVegetarischeProdukte)
            : base(nameeinkaufsladen, platzierung, abteilung, nrangestellte, kundenanzahltag, einkommen, kategorie)
        {
            AnzahlVegetarischeProdukte = anzahlVegetarischeProdukte;
        }

        public override void ZeigeKategorie()
        {
            Console.WriteLine("Vegetarische Kategorie: " + Kategorie);
        }

        public void ZeigeAnzahlVegetarischeProdukte()
        {
            Console.WriteLine("Anzahl vegetarischer Produkte: " + AnzahlVegetarischeProdukte);
        }

        public bool SindGenugProdukteVorhanden(int benötigteProdukte)
        {
            return AnzahlVegetarischeProdukte >= benötigteProdukte;
        }
    }
}