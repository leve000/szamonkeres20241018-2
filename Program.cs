using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek, add meg a diák pontszámát (0 és 100 között):");
            int pontszam;

            if (int.TryParse(Console.ReadLine(), out pontszam))
            {
                if (pontszam < 0 || pontszam > 100)
                {
                    Console.WriteLine("Érvénytelen pontszám");
                }
                else
                {
                    if (pontszam >= 0 && pontszam <= 49)
                    {
                        Console.WriteLine("Elégtelen");
                    }
                    else if (pontszam >= 50 && pontszam <= 59)
                    {
                        Console.WriteLine("Elégséges");
                    }
                    else if (pontszam >= 60 && pontszam <= 79)
                    {
                        Console.WriteLine("Közepes");
                    }
                    else if (pontszam >= 80 && pontszam <= 89)
                    {
                        Console.WriteLine("Jó");
                    }
                    else if (pontszam >= 90 && pontszam <= 100)
                    {
                        Console.WriteLine("Jeles");
                    }
                }
            }

        }
    }
}
