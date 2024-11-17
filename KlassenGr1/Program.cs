using Elektronik;

namespace KlassenGr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produkte = new Dictionary<string, (decimal Preis, int Menge)>
        {
            { "Laptop", (999.99m, 10) },
            { "Smartphone", (699.99m, 20) },
            { "Tablet", (399.99m, 15) },
            { "Kopfhörer", (149.99m, 30) },
            { "Smartwatch", (199.99m, 25) },
            { "Fernseher", (1499.99m, 5) },
            { "Waschmaschine", (499.99m, 10) },
            { "Kühlschrank", (799.99m, 8) },
            { "Mikrowelle", (99.99m, 12) },
            { "Kaffeemaschine", (49.99m, 20) },
            { "Staubsauger", (199.99m, 15) },
            { "Toaster", (29.99m, 25) },
            { "Bügeleisen", (19.99m, 30) },
            { "Drucker", (99.99m, 15) },
            { "Scanner", (79.99m, 20) },
            { "Lautsprecher", (149.99m, 25) },
            { "Gaming-PC", (1499.99m, 5) },
            { "Gaming-Laptop", (1999.99m, 8) },
            { "Gaming-Konsole", (399.99m, 12) },
            { "Gaming-Zubehör", (49.99m, 20) },
            { "Gaming-Stuhl", (199.99m, 15) },
            { "Gaming-Maus", (29.99m, 25) },
            { "Gaming-Tastatur", (19.99m, 30) },
            { "Gaming-Headset", (49.99m, 10) },
            { "Gaming-Monitor", (199.99m, 15) },
            { "Gaming-Mauspad", (9.99m, 20) },
            { "Gaming-Controller", (39.99m, 25) },
            { "Gaming-Router", (99.99m, 30) },
            { "Gaming-Handy", (699.99m, 10) },
            { "Gaming-Tablet", (399.99m, 15) },
            { "Gaming-Smartwatch", (199.99m, 20) },
            { "Gaming-Fernseher", (1499.99m, 25) },
        };

            ElektronikAbteilung elektronik = new ElektronikAbteilung(
                "Altex",
                "Sibiu",
                "Elektronik",
                20,
                200,
                50000.5f,
                45,
                "Elektronikgeräte und Haushaltsapparatur",
                produkte
            );

            // Produkte anzeigen
            elektronik.ZeigeAlleProdukte();

            // Produkt verkaufen
            elektronik.ProduktVerkaufen("Laptop");
            elektronik.ProduktVerkaufen("Smartphone");

            // Produkte erneut anzeigen
            elektronik.ZeigeAlleProdukte();

            // Neues Produkt hinzufügen
            elektronik.ProduktHinzufuegen("Kamera", 249.99m, 5);

            // Produkte anzeigen
            elektronik.ZeigeAlleProdukte();
        }
    }
}