using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les7boules
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Les 7 boules seront choisies au hasard entre 1 et 50");
        }

        static int
        {
            List<int> cinquanteBoules;
            cinquanteBoules = new List<int>();

            int i = 1;
            for (i = 0; i <= 50; i++)
            {
                cinquanteBoules.Add(i);
                Console.WriteLine(cinquanteBoules);
            }
        }

/// //////////////////////////////////////////

        static int random()
        {
            Random random = new Random();
            int ballNumber = random.Next(1, 49);
            // return 
            return ballNumber;                
        }
    }
}
