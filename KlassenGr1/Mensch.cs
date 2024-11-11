using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Mensch
    {
        int cnp=0;
        string haarfarbe="";
        string geschlecht="";
        string nameVorname = "";
        int grcm = 0, gw=0;

        public int CNP { get; set; }

        public string HaarFarbe { get; set; }

        public string Geschlecht { get; set; }

        public string NameVorname { get; set; }

        public int Grcm { get; set; }

        public int Gw { get; set; }

        public Mensch() { }
        public Mensch(int cnp, string haarfarbe, string geschlecht, string nameVorname, int grcm, int gw) {
        this.cnp = cnp;
        this.haarfarbe = haarfarbe; 
        this.geschlecht = geschlecht;
        this.nameVorname = nameVorname;
        this.grcm = grcm;   
        this.gw=gw;
        }

        public virtual int lebensdauer()
        {
            Random rnd = new Random();

            return rnd.Next();
        }


    }
}
