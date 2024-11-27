using System;

namespace KlassenGr1
{
    internal class Outlet : NeueKleider
    {
        private int stock; 
        private float discount; 

        public Outlet()
            : base("", "", 0, "", false, 0, 0)
        {
            stock = 0;
            discount = 0;
        }

        public Outlet(string nameeinkaufsladen, string platzierung, int kundenanzahltag, string kleidungstyp, bool sonderangebot, float angebotProzent, int stock)
            : base(nameeinkaufsladen, platzierung, kundenanzahltag, kleidungstyp, sonderangebot, angebotProzent, stock)
        {
            this.stock = stock;
            this.discount = angebotProzent;
        }

        public void AddStock(int newStock)
        {
            stock += newStock;
            Console.WriteLine("Es wurden " + newStock + " Stücke hinzugefügt. Gesamtlagerbestand: " + stock);
        }

        public void SellStock(int soldStock)
        {
            if (stock >= soldStock)
            {
                stock -= soldStock;
                Console.WriteLine(soldStock + " Stücke wurden verkauft. Verbleibender Lagerbestand: " + stock);
            }
            else
            {
                Console.WriteLine("Nicht genügend Lagerbestand, um " + soldStock + " zu verkaufen.");
            }
        }

        public override void Angebot()
        {
            Console.WriteLine(Nameeinkaufsladen + " bietet einen Rabatt von " + discount + "% auf alle Artikel an!");
            if (Sonderangebot)
            {
                Console.WriteLine("Zusätzlich gibt es Sonderangebote auf " + Kleidungstyp + ".");
            }
        }

        public override void buyNewStock()
        {
            if (stock < 15)
            {
                Console.WriteLine("Der Lagerbestand ist niedrig. Bitte kaufen Sie mindestens 30 weitere Stücke ein.");
            }
        }
    }
}
