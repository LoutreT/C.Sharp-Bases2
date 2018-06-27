using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Training4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 17 ||
                DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                SalutationBonWE(); // cette fonction fait appel à la fonction plus bas qui permet par
                // exemple de changer la salutation en toute les langues (français, anglais, espagnol,...)
                if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour <= 12)
                {
                    Console.WriteLine("...Bonne journée !");
                }
                if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 18)
                {
                    Console.WriteLine("...Bon après-midi !");
                }
                if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 21)
                {
                    Console.WriteLine("...Bonne soirée !");
                }
                else
                {
                    Console.WriteLine("...Bonne nuit !");
                }
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                SalutationBonneFindeWE();
                if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour <= 12)
                {
                    Console.WriteLine("...Bonne journée !");
                }
                if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 18)
                {
                    Console.WriteLine("...Bon après-midi !");
                }
                if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 21)
                {
                    Console.WriteLine("...Bonne soirée !");
                }
                else
                {
                    Console.WriteLine("...Bonne nuit !");
                }
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday ||
                DateTime.Now.DayOfWeek == DayOfWeek.Tuesday ||
                DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                SalutationBonneSemaine();
                if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour <= 11)
                {
                    Console.WriteLine("...Bonne journée !");
                }
                if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 18)
                {
                    Console.WriteLine("...Bon après-midi !");
                }
                if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 21)
                {
                    Console.WriteLine("...Bonne soirée !");
                }
                else
                {
                    Console.WriteLine("...Bonne nuit !");
                }
            }
            else
            {
                SalutationBonneFindeSemaine();
                if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour <= 11)
                {
                    Console.WriteLine("...Bonne journée !");
                }
                if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 18)
                {
                    Console.WriteLine("...Bon après-midi !");
                }
                if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 21)
                {
                    Console.WriteLine("...Bonne soirée !");
                }
                else
                {
                    Console.WriteLine("...Bonne nuit !");
                }
            }
        }

        static void SalutationBonWE()
        {
            Console.WriteLine("Bon Week-End ! et...");
        }

        static void SalutationBonneFindeWE()
        {
            Console.WriteLine("Bonne fin de week-end ! et...");
        }

        static void SalutationBonneSemaine()
        {
            Console.WriteLine("Bonne semaine ! et...");
        }

        static void SalutationBonneFindeSemaine()
        {
            Console.WriteLine("Bonne fin de semaine ! et...");
        }
    }
}

