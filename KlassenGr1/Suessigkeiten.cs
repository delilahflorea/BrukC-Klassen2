using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenGr1
{
 
        internal class Suessigkeiten : Lebensmittel
        {
            public string SuessigkeitenTyp { get; set; } 
            public int HaltbarkeitInTagen { get; set; }  
            public bool EnthaltZucker { get; set; }      

            //Konstruktor 777
            public Suessigkeiten() : base() // Ruft den konstruktor auf
            {
                SuessigkeitenTyp = "-";
                HaltbarkeitInTagen = 0;
                EnthaltZucker = false;
            }

            // Konstruktur mit parameter
            public Suessigkeiten(
                string nameEinkaufsladen,
                string platzierung,
                string abteilung,
                int nrangestellte,
                int kundenanzahltag,
                float einkommen,
                string kategorie,
                string suessigkeitenTyp,
                int haltbarkeitInTagen,
                bool enthaltZucker)
                : base(nameEinkaufsladen, platzierung, abteilung, nrangestellte, kundenanzahltag, einkommen, kategorie)
            {
                SuessigkeitenTyp = suessigkeitenTyp;
                HaltbarkeitInTagen = haltbarkeitInTagen;
                EnthaltZucker = enthaltZucker;
            }

            // frisch?
            public string FrischePruefen()
            {
                if (HaltbarkeitInTagen > 30)
                    return "Lange Haltbarkeit.";
                else
                    return "Kurze Haltbarkeit!";
            }

            // offen/geschlossen?
            public override bool OffenGeschlossen(int uhrzeit)
            {
                // Süßigkeitenläden haben andere Öffnungszeiten
                if (uhrzeit >= 10 && uhrzeit <= 20)
                    return true;
                else
                    return false;
            }

            // Infos anzeigen
            public void ZeigeSuessigkeitenInfo()
            {
                Console.WriteLine("Sussigkeitentyp: " + SuessigkeitenTyp);
                Console.WriteLine("Haltbarkeit: " + HaltbarkeitInTagen + " Tage");
                Console.WriteLine("Enthalt Zucker: " + (EnthaltZucker ? "Ja" : "Nein"));
            }
        }
    }
}
