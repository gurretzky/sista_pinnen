using System;

namespace sista_pinnen
{
    class Program
    {
        static void Main(string[] args)
        {
        tryagain:
            Console.Clear();
            string s1namn, s2namn;
            int pinnar = 12, subtraktion;
            Console.WriteLine("Välkommen till sista pinnen. Du får plocka max 3 pinnar och minst 1. Den som plockar den sista pinnen förlorar.\n" +
                "Tryck på ENTER för att börja.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Mata in spelare 1 användarnamn: ");
            s1namn = Console.ReadLine();
            Console.Write("Mata in spelare 2 användarnamn: ");
            s2namn = Console.ReadLine();
            Console.Clear();
            try
            {
                do
                {
                    Console.Write("Det är {0}s tur. Det finns {1} pinnar. Hur många pinnar vill du ta?\n" +
                        "Inmatning: ", s1namn, pinnar);
                    subtraktion = Convert.ToInt32(Console.ReadLine());
                    pinnar = pinnar - subtraktion;
                    Console.Clear();
                    if (pinnar == 0)
                    {
                        Console.WriteLine("{0} förlorade spelet och {1} vann.", s1namn, s2namn);
                    }
                    else if (pinnar > 0)
                    {
                        Console.Write("Det är {0}s tur. Det finns {1} pinnar. Hur många pinnar vill du ta?\n" +
                        "Inmatning: ", s2namn, pinnar);
                        subtraktion = Convert.ToInt32(Console.ReadLine());
                        pinnar = pinnar - subtraktion;
                        Console.Clear();
                        if (pinnar == 0)
                        {
                            Console.WriteLine("{0} förlorade spelet och {1} vann.", s2namn, s1namn);
                        }
                    }
                } while (pinnar > 0);
            }
            catch
            {
                Console.WriteLine("Felaktig inmatning. Tryck på ENTER för att fortsätta.");
                Console.ReadKey();
                goto tryagain;
            }
            Console.ReadKey();
        }
    }
}
