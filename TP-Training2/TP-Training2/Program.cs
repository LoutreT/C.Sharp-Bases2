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
            if(DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Bonne journée");
            }
            else
            {
                Console.WriteLine("Bonne semaine");
            }
        }
    }
}
