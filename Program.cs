using System;

namespace Projekt_alles_mögliche
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |------------------------------------------------|");
            Console.WriteLine("     | Willkomen in meinem kleinen Konsolen Programm! |");
            Console.WriteLine("     |------------------------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.Beep();
            Menu();
        }
        static void Menu()
        {
            string y;

                //Menü text
                Console.WriteLine("     Bitte wähle eine Sache aus, die du machen willst.");
                Console.WriteLine("");
                Console.WriteLine("     1 Kleiner Taschenrechner");
                Console.WriteLine("     2 Berechnungen am Kreis");
                Console.WriteLine("     3 Noten durchschnitt ermitteln");
                Console.WriteLine("");
                Console.WriteLine("     Bitte gib jetzt den Menü Punkt als Zahl ein, um zu diesem zu gelangen:");
                //Menü verarbeitung
                y = Console.ReadLine();
                if (y == "1")
                {
                    taschenrechner();
                }
                else if (y == "2")
                {
                    Kreisstart();
                }
                else if (y == "3")
                {

                }
                else
                {
                    Console.WriteLine("     Eingabe Ungültig!");
                    Console.WriteLine("");
                    Start();
                }
        }
        static void taschenrechner()
        {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("     |---------------------------|");
                Console.WriteLine("     | Der kleine Taschenrechner |");
                Console.WriteLine("     |---------------------------|");
                Console.WriteLine("         | by Dr.PPSN |");
                Console.WriteLine("         --------------");
                Console.WriteLine("");
                Console.WriteLine("     Bitte drücke jedes mal die Enter Taste um zu bestätigen!");
                Console.ReadLine();
                //erste Zahl
                Console.WriteLine("     Bitte gib die erste Zahl ein:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                //operator eingabe
                Console.WriteLine("     Bitte gib jetzt +,-,* oder / ein:");
                string a = Console.ReadLine();
                Console.WriteLine("");

                //zweite Zahl
                Console.WriteLine("     Bitte gib die Zweite Zahl ein:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                //var b erstellen
                int b = 0;

                //überprüfen des Operators

                if (a == "+")
                {
                    b = 1;
                }
                if (a == "-")
                {
                    b = 2;
                }
                if (a == "*")
                {
                    b = 3;
                }
                if (a == "/")
                {
                    b = 4;
                }

                //rechnen der var x und y
                switch (b)
                {
                    case 1:
                        Console.WriteLine("     Das Ergebnis ist:");
                        Console.WriteLine(x + y);
                        Console.WriteLine("");
                        Console.ReadLine();
                    Start();
                    break;

                    case 2:
                        Console.WriteLine("     Das Ergebnis ist:");
                        Console.WriteLine(x - y);
                        Console.ReadLine();
                    Start();
                    break;

                    case 3:
                        Console.WriteLine("     Das Ergebnis ist:");
                        Console.WriteLine(x * y);
                        Console.ReadLine();
                    Start();
                    break;

                    case 4:
                        Console.WriteLine("     Das Ergebnis ist:");
                        Console.WriteLine(x / y);
                        Console.ReadLine();
                    Start();
                    break;
                }
        }
        static void Kreisstart()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |--------------------------|");
            Console.WriteLine("     | Berechnungen mit Kreisen |");
            Console.WriteLine("     |--------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            Console.WriteLine("     Berechnungen von Kreisen");
            Console.WriteLine("");
            Console.WriteLine("     Willst du den Radius berechnen, dann schreibe ein R in die Konsole.");
            Console.WriteLine("     Willst du den Umfang berechnen, dann schreibe ein U in die Konsole.");
            Console.WriteLine("     Willst du den Flächeninhalt berechnen, dann schreibe ein F in die Konsole.");
            Console.WriteLine("     Um zurück ins Menü zu gelangen, schreibe bitte ein E in die Konsole.");
            Console.WriteLine("");

            //Eingabe der Werte
            string eingabe = Console.ReadLine();
            if(eingabe == "r")
            {

            }
            else if(eingabe == "R")
            {

            }
            else if(eingabe == "u")
            {

            }
            else if (eingabe == "U")
            {

            }
            else if (eingabe == "f")
            {
                Flaecheninhalt();
            }
            else if (eingabe == "F")
            {
                Flaecheninhalt();
            }
            else if (eingabe == "e")
            {
                Start();
            }
            else if (eingabe == "E")
            {
                Start();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Kreisstart();
            }
        }
        static void Flaecheninhalt()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |---------------------------------------|");
            Console.WriteLine("     | Flächeninhalt eines Kreises berechnen |");
            Console.WriteLine("     |---------------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            Console.WriteLine("     Es wird in centimetern gerechnet.");
            Console.WriteLine("     Um den Flächeninhalt zu berechnen, gib bitte den Radius, des Kreises ein:");
            Console.WriteLine("");
            //Eingabe der Werte
            const double pi = 3.14;
            double radius = Convert.ToDouble(Console.ReadLine());

            //ausgabe der Berechneten Fläche
            Console.WriteLine("");
            Console.WriteLine("     Ein Kreis mit einen Radius von "+radius+" cm^2 hat einen Flächeninhalt von:");
            Console.WriteLine(pi * radius * radius + " cm^2");
            Console.ReadLine();
            Kreisstart();
        }
    }
}