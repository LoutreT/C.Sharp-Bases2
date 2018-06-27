using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Training3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 17 || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Bon Week-End ! et...");
                if(DateTime.Now.Hour >= 4 && DateTime.Now.Hour <= 12)
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
                Console.WriteLine("Bonne fin de week-end ! et...");
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
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday || DateTime.Now.DayOfWeek == DayOfWeek.Tuesday || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Bonne semaine ! et...");
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
                    Console.WriteLine("...Bonne nuit !" + Environment.UserName);


                }
            }
            else
            {
                Console.WriteLine("Bonne fin de semaine ! et...");
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
    }
}
