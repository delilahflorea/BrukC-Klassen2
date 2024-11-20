using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class NeueKleider : Kleidereinkauf
    {
        float AngebotProzent { get; set; }
        int stockAmount { get; set; }

        public NeueKleider(string nameeinkaufsladen, string platzierung, int kundenanzahltag, string kleidungstyp, bool sonderangebot, float AngebotProzent, int stockAmount)
            : base(nameeinkaufsladen, platzierung, kundenanzahltag, kleidungstyp, sonderangebot)
        {
            this.AngebotProzent = AngebotProzent;
            this.stockAmount = stockAmount;
        }

        public override void Angebot()
        {
            if(Sonderangebot)
                Console.WriteLine(Nameeinkaufsladen + " hat einen Angebot an " + Kleidungstyp + " von " + AngebotProzent + "%!");
        }

        public void addStock(int added)
        {
            this.stockAmount += added;
            Console.WriteLine("Man hat " + added + " mehr Stucke von " + Kleidungstyp +" gekauft!. Der neue Total ist: " + this.stockAmount);
        }

        public int recommendedStock()
        {
            if(this.AngebotProzent>30)
                return 50;
            return 30;
        }

        public virtual void buyNewStock()
        {
            if(stockAmount < 20) 
                Console.WriteLine("Es müssen neue Lagerbestände gekauft werden. Wir empfehlen den Kauf von " + recommendedStock() + " weiteren Stücken!");
            
        }
    }
}
