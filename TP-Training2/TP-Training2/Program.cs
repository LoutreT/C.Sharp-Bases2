using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Training2
{
    class Program
    {
        static void Main(string[] args)
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 17 || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Bon Week-End");
            }
            if(DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Bon fin de week-end");
            }

        }
    }
}
