using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ExerciceChapitre15Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> groupeboules = new List<int>();

            //  List.Sort(Groupe49boules);
            
            for (int i = 1; i <= 49; i += 1)
            {
                groupeboules.Add(i);
            }
            Console.WriteLine(groupeboules);

            // Random.Groupe49boules();
            // RemoveAt(Random.Groupe49boules());

            // Réalisation du tableau de 7

            // int[] loto7 = new int[7];
        }

    }
}
