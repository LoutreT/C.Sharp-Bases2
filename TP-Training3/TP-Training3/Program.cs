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
                Console.WriteLine("Bon Week-End !");
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Bonne fin de week-end !");
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday || DateTime.Now.DayOfWeek == DayOfWeek.Tuesday || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Bonne semaine !");
            }
            else
            {
                Console.WriteLine("Bonne fin de semaine !");
            }
        }
    }
}
