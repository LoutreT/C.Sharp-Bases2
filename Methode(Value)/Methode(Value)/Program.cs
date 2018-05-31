using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_Value_
{
    class Program
    {
        static double LonguHypothenuse(double a,double b)
        {
            double sommeDesCarres = a * a + b * b;
            double resultat = Math.Sqrt(sommeDesCarres);
            return resultat;
        }

        static void Main(string[] args)
        {
            double valeur = LonguHypothenuse(1, 3);
            Console.WriteLine(valeur);
            valeur = LonguHypothenuse(10, 10);
            Console.WriteLine(valeur);
        }
    }
}
