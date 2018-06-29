using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Methode2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            {
                double somme = 0;

                foreach (double valeur in liste)
                {
                    somme += valeur;
                }
                Console.WriteLine(somme / liste.Count);    // ici je le divise 
                          // en 5 éléments consituant la liste et donc = 5,76
            }
        
        }
    }
}
