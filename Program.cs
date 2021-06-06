using System;
using System.Linq;

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
                Console.WriteLine("     E Das Programm beenden");
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
                else if (y == "e" || y == "E")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                Start();
                }
        }
        static void taschenrechner()
        {
            string e;
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("     |---------------------------|");
                Console.WriteLine("     | Der kleine Taschenrechner |");
                Console.WriteLine("     |---------------------------|");
                Console.WriteLine("         | by Dr.PPSN |");
                Console.WriteLine("         --------------");
                Console.WriteLine("");
                Console.WriteLine("     Bitte drücke jedes mal die Enter Taste um zu bestätigen!");
                Console.WriteLine("     Es kann in diesem Taschenrechner nur mit ganzen Reelen Zahlen gerechnet werden!");
                Console.WriteLine("     Um ins Hauptmenü zu gelangen schreibe ein E und drücke die Enter Taste");
                e = Console.ReadLine();
                if(e=="e"||e=="E")
                {
                    Start();
                }
                    //erste Zahl
                Console.WriteLine("     Bitte gib die erste Zahl ein:");
                string erste = Console.ReadLine();
                double x=0;
                if (erste.All(char.IsDigit))
                {
                    x = Convert.ToDouble(erste);
                    Console.WriteLine("");
                }
                else if (erste=="e"||erste=="E")
                {
                    Start();
                }
                else
                {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                taschenrechner();
            }
                Console.WriteLine("");

                //operator eingabe
                Console.WriteLine("     Bitte gib jetzt +,-,*,/ oder E ein:");
                string a = Console.ReadLine();
                Console.WriteLine("");

                

                //var b erstellen
                int b = 0;

                //überprüfen des Operators

                if (a == "+")
                {
                    b = 1;
                }
                else if (a == "-")
                {
                    b = 2;
                }
                else if (a == "*")
                {
                    b = 3;
                }
                else if (a == "/")
                {
                    b = 4;
                }
                else if (a=="e"||a=="E")
                {
                    Start();
                }
                else
                {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                taschenrechner();
                }
                //zweite Zahl
                Console.WriteLine("     Bitte gib die Zweite Zahl ein:");
                double y=0;
                string zweite = Console.ReadLine();
                Console.WriteLine("");
                if (zweite.All(char.IsDigit))
                {
                    y = Convert.ToDouble(zweite);
                }
                else if (zweite=="e"||zweite=="E")
                {
                    Start();
                }
                else
                {
                    Console.WriteLine("     Eingabe Ungültig!");
                    Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren.");
                    Console.ReadLine();
                    taschenrechner();
                }
                //rechnen der var x und y
                switch (b)
                {
                    case 1:
                        Console.WriteLine("     Das Ergebnis ist:");
                        Console.WriteLine(x + y);
                        Console.WriteLine("");
                        Console.ReadLine();
                        taschenrechner();
                    break;

                    case 2:
                        Console.WriteLine("     Das Ergebnis ist:");
                        Console.WriteLine(x - y);
                        Console.ReadLine();
                        taschenrechner();
                    break;

                    case 3:
                        Console.WriteLine("     Das Ergebnis ist:");
                        Console.WriteLine(x * y);
                        Console.ReadLine();
                        taschenrechner();
                    break;

                    case 4:
                        Console.WriteLine("     Das Ergebnis ist:");
                        Console.WriteLine(x / y);
                        Console.ReadLine();
                        taschenrechner();
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
            Console.WriteLine("     Willst du den Radius berechnen, dann schreibe ein R in die Konsole.");
            Console.WriteLine("     Willst du den Umfang berechnen, dann schreibe ein U in die Konsole.");
            Console.WriteLine("     Willst du den Flächeninhalt berechnen, dann schreibe ein F in die Konsole.");
            Console.WriteLine("     Um zurück ins Menü zu gelangen, schreibe bitte ein E in die Konsole.");
            Console.WriteLine("");

            //Eingabe der Werte
            string eingabe = Console.ReadLine();
            if(eingabe == "r"|| eingabe == "R")
            {
                radius();
            }
            else if(eingabe == "u"|| eingabe == "U")
            {
                umfang();
            }
            else if (eingabe == "f"|| eingabe == "F")
            {
                Flaecheninhalt();
            }
            else if (eingabe == "e"|| eingabe == "E")
            {
                Start();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
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
            Console.WriteLine("     Um den Flächeninhalt zu berechnen, gib bitte den Radius, des Kreises ein,");
            Console.WriteLine("     oder schreibe ein E um ins vorherige Menü zu gelangen.");
            Console.WriteLine("");
            //Eingabe der Werte
            const double pi = 3.14;
            string fl=Console.ReadLine();
            double radius;

            //überprüfen ob die eingabe eine Zahl ist
            if (fl.All(char.IsDigit))
            {
                //ausgabe der Berechneten Fläche
                radius = Convert.ToDouble(fl);
                Console.WriteLine("");
                Console.WriteLine("     Ein Kreis mit einen Radius von " + radius + " cm hat einen Flächeninhalt von:");
                Console.WriteLine(pi * radius * radius + " cm^2");
                Console.ReadLine();
                Flaecheninhalt();
            }
            else if(fl=="E")
            {
                Kreisstart();
            }
            else if (fl=="e")
            {
                Kreisstart();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                Kreisstart();
            }
        }
        static void radius()
        {
            string y;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("     | Radius eines Kreises Berechnen |");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            //Menü text
            Console.WriteLine("     Bitte wähle aus was dir gegeben ist.");
            Console.WriteLine("");
            Console.WriteLine("     1 Der Flächeninhalt ist gegeben");
            Console.WriteLine("     2 Der Umfang ist gegeben");
            Console.WriteLine("     3 Der Durchmesser ist gegeben");
            Console.WriteLine("     E Zurück ins vorherige Menü");
            Console.WriteLine("");
            y = Console.ReadLine();
            if (y == "1")
            {
                radiuseins();
            }
            else if (y == "2")
            {
                radiuszwei();
            }
            else if (y == "3")
            {
                radiusdrei();
            }
            else if (y == "E" || y == "e")
            {
                Kreisstart();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                radius();
            }
        }
        static void radiuseins()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("     | Radius eines Kreises Berechnen |");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            Console.WriteLine("     Bitte gib jetzt den Flächeninhalt als Zahl ein,");
            Console.WriteLine("     oder schreibe ein E um ins vorherige Menü zu gelangen.");
            Console.WriteLine("");
            //eingabe, überprüfen ob es eine Zahl ist und berechnung
            const double pi = 3.14;
            string geg = Console.ReadLine();
            double erg;
            if (geg.All(char.IsDigit))
            {
                //ausgabe der Berechneten Fläche
                erg = Convert.ToDouble(geg);
                Console.WriteLine("");
                Console.WriteLine("     Ein Kreis mit einem Flächeninhalt von "+erg+" cm^2");
                Console.WriteLine("     hat einen Radius von "+Math.Sqrt(erg/pi)+" cm");
                Console.ReadLine();
                radiuseins();
            }
            else if (geg == "E"|| geg == "e")
            {
                radius();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                radiuseins();
            }
        }
        static void radiuszwei()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("     | Radius eines Kreises Berechnen |");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            Console.WriteLine("     Bitte gib jetzt den Umfang als Zahl ein,");
            Console.WriteLine("     oder schreibe ein E um ins vorherige Menü zu gelangen.");
            Console.WriteLine("");
            //eingabe, überprüfen ob es eine Zahl ist und berechnung
            const double pi = 3.14;
            string geg = Console.ReadLine();
            double erg;
            if (geg.All(char.IsDigit))
            {
                //ausgabe des Berechneten
                erg = Convert.ToDouble(geg);
                Console.WriteLine("");
                Console.WriteLine("     Ein Kreis mit einem Umfang von " + erg + " cm");
                Console.WriteLine("     hat einen Radius von " + erg/(2*pi) + " cm");
                Console.ReadLine();
                radiuszwei();
            }
            else if (geg == "E" || geg == "e")
            {
                radius();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                radiuszwei();
            }
        }
        static void radiusdrei()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("     | Radius eines Kreises Berechnen |");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            Console.WriteLine("     Bitte gib jetzt den Durchmesser als Zahl ein,");
            Console.WriteLine("     oder schreibe ein E um ins vorherige Menü zu gelangen.");
            Console.WriteLine("");
            //eingabe, überprüfen ob es eine Zahl ist und berechnung
            string geg = Console.ReadLine();
            double erg;
            if (geg.All(char.IsDigit))
            {
                //ausgabe des Berechneten
                erg = Convert.ToDouble(geg);
                Console.WriteLine("");
                Console.WriteLine("     Ein Kreis mit einem Durchmesser von " + erg + " cm");
                Console.WriteLine("     hat einen Radius von " + erg / 2 + " cm");
                Console.ReadLine();
                radiusdrei();
            }
            else if (geg == "E" || geg == "e")
            {
                radius();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                radiusdrei();
            }
        }
        static void umfang()
        {
            string y;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("     | Umfang eines Kreises Berechnen |");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            //Menü text
            Console.WriteLine("     Bitte wähle aus was dir gegeben ist.");
            Console.WriteLine("");
            Console.WriteLine("     1 Der Flächeninhalt ist gegeben");
            Console.WriteLine("     2 Der Radius ist gegeben");
            Console.WriteLine("     3 Der Durchmesser ist gegeben");
            Console.WriteLine("     E Zurück ins vorherige Menü");
            Console.WriteLine("");
            y = Console.ReadLine();
            if (y == "1")
            {
                umfangeins();
            }
            else if (y == "2")
            {
                umfangzwei();
            }
            else if (y == "3")
            {
                umfangdrei();
            }
            else if (y == "E" || y == "e")
            {
                Kreisstart();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                radius();
            }
        }
        static void umfangeins()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("     | Umfang eines Kreises Berechnen |");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            Console.WriteLine("     Bitte gib jetzt den Flächeninhalt als Zahl ein,");
            Console.WriteLine("     oder schreibe ein E um ins vorherige Menü zu gelangen.");
            Console.WriteLine("");
            //eingabe, überprüfen ob es eine Zahl ist und berechnung
            //const double pi = 3.14;
            //string geg = Console.ReadLine();
            //double erg;
            umfang();
            /*if (geg.All(char.IsDigit))
            {
                //ausgabe der Berechneten Fläche
                erg = Convert.ToDouble(geg);
                Console.WriteLine("");
                Console.WriteLine("     Ein Kreis mit einem Flächeninhalt von " + erg + " cm^2");
                Console.WriteLine("     hat einen Umfang von    cm");
                Console.ReadLine();
                umfangeins();
            }
            else if (geg == "E" || geg == "e")
            {
                umfang();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                umfangeins();
            }*/
        }
        static void umfangzwei()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("     | Umfang eines Kreises Berechnen |");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            Console.WriteLine("     Bitte gib jetzt den Radius als Zahl ein,");
            Console.WriteLine("     oder schreibe ein E um ins vorherige Menü zu gelangen.");
            Console.WriteLine("");
            //eingabe, überprüfen ob es eine Zahl ist und berechnung
            const double pi = 3.14;
            string geg = Console.ReadLine();
            double erg;
            if (geg.All(char.IsDigit))
            {
                //ausgabe der Berechneten Fläche
                erg = Convert.ToDouble(geg);
                Console.WriteLine("");
                Console.WriteLine("     Ein Kreis mit einem Radius von " + erg + " cm");
                Console.WriteLine("     hat einen Umfang von " + 2*erg*pi + " cm");
                Console.ReadLine();
                umfangzwei();
            }
            else if (geg == "E" || geg == "e")
            {
                umfang();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                umfangzwei();
            }
        }
        static void umfangdrei()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("     | Umfang eines Kreises Berechnen |");
            Console.WriteLine("     |--------------------------------|");
            Console.WriteLine("         | by Dr.PPSN |");
            Console.WriteLine("         --------------");
            Console.WriteLine("");
            Console.WriteLine("     Bitte gib jetzt den Durchmesser als Zahl ein,");
            Console.WriteLine("     oder schreibe ein E um ins vorherige Menü zu gelangen.");
            Console.WriteLine("");
            //eingabe, überprüfen ob es eine Zahl ist und berechnung
            const double pi = 3.14;
            string geg = Console.ReadLine();
            double erg;
            if (geg.All(char.IsDigit))
            {
                //ausgabe der Berechneten Fläche
                erg = Convert.ToDouble(geg);
                Console.WriteLine("");
                Console.WriteLine("     Ein Kreis mit einem Durchmesser von " + erg + " cm");
                Console.WriteLine("     hat einen Umfang von " + erg*pi + " cm");
                Console.ReadLine();
                umfangdrei();
            }
            else if (geg == "E" || geg == "e")
            {
                umfang();
            }
            else
            {
                Console.WriteLine("     Eingabe Ungültig!");
                Console.WriteLine("     Bitte drücke die Enter Taste um fortzufahren");
                Console.ReadLine();
                umfangdrei();
            }
        }
    }
}