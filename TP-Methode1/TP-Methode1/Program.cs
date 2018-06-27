using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Methode1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int CalculTotal(int Min, int Max)
        { 
            int Total = 0;
            List<int> Pouraditionner = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int element in Pouraditionner)
            {
                Total += element;
            }
            return Total;
        }

    }
}
