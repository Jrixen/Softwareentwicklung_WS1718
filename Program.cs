using System;

static class ZufallszahlRaten
{
    static void Main(string[] args)
    {
        //1. Schleife, damit das Spiel nach Abschluss erneut ausgeführt werden kann.
        while (true)
        {
            int Zufallszahl = NeueZahl(1, 101);
            int Versuchanzahl = 1;

            //2. Schleife für die Zahleingabe und -auswertung.
            while (true)
            {
                Console.Write("Gib eine Zahl zwischen 1 und 100 ein(0 zum Abbrechen):");
                int Eingabe = Convert.ToInt32(Console.ReadLine());

                if (Eingabe == 0)
                    return;

                else if (Eingabe < Zufallszahl)
                {
                    Console.WriteLine("Zu niedrig, versuche es nochmal.");
                    ++Versuchanzahl;
                    continue;
                }
                else if (Eingabe > Zufallszahl)
                {
                    Console.WriteLine("Zu hoch, versuche es nochmal.");
                    ++Versuchanzahl;
                    continue;
                }
                else
                {
                    Console.WriteLine("Korrekt! Die Zufallszahl war {0}!", Zufallszahl);
                    Console.WriteLine("Du hast {0} {1}.\n", Versuchanzahl, Versuchanzahl == 1 ? "Versuch benötigt" : "Versuche benötigt");
                    break;
                }
            }
        }
    }

    //Generierung einer neuen Zufallszahl
    static int NeueZahl(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

}
