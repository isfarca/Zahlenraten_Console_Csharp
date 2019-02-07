using System;

namespace Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            string Eingabe;
            int EingabeZahl = 0;

            Random Zufall = new Random();
            int Zufallszahl = Zufall.Next(0, 100);
            int Differenz;

            bool Fehler;
            bool Korrekt = false;

            do
            {
                do
                {
                    Fehler = false;

                    Console.Write("Bitte geben Sie eine Zahl zwischen 0 und 100 ein: ");
                    Eingabe = Console.ReadLine();
                    try
                    {
                        EingabeZahl = Convert.ToInt32(Eingabe);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("FEHLER! Bitte geben Sie nur ganze Zahlen ein.\n");
                        Console.ResetColor();

                        Fehler = true;
                    }
                }
                while (Fehler);

                Differenz = Math.Abs(Zufallszahl - EingabeZahl);

                if (Differenz > 0 && Differenz <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Heiß\n");
                    Console.ResetColor();
                }
                else if (Differenz > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Kalt\n");
                    Console.ResetColor();
                }
                else if (Differenz == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nGefunden");
                    Console.ResetColor();

                    Korrekt = true;
                }
            }
            while (!Korrekt);

            Console.ReadKey();
        }
    }
}
