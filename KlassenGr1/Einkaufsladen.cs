using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
    internal class Einkaufsladen
    {
        string nameeinkaufsladen="";
        string platzierung="";
        string abteilung="";
        int nrangestellte=0;
        int kundenanzahltag=0;
        float einkommen=0f;

       
        public string Nameeinkaufsladen { get; set; }

        public string Platzierung { get; set; }
        
        public string Abteilung { get; set; }

        public int Nrangestellte { get; set; }

        public int Kundenanzahltag { get; set; }    

        public float Einkommen { get; set; }    

        public Einkaufsladen() { }
        public Einkaufsladen(string nameeinkaufsladen, string platzierung, string abteilung, int nrangestellte, int kundenanzahltag, float einkommen) {
        this. nameeinkaufsladen = nameeinkaufsladen;
        this.platzierung = platzierung;
        this.abteilung = abteilung;
        this.nrangestellte = nrangestellte;
        this.kundenanzahltag = kundenanzahltag;
        this.einkommen = einkommen;
        }

         public virtual bool offengeschlossen(int uhrzeit)
        {
            if(uhrzeit>8 && uhrzeit<18)
                return true;
            else
                return false;
        }
    }
}
