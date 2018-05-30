using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeCSharpBases2
{
    class Program
    {
        static void Main(string[] args)
        {
            AffichageBienvenue();
            AffichageBienvenue();
        }

        static void AffichageBienvenue()   // j'ai supprimé l'origine : (string[] args)
        {
            Console.WriteLine("Bonjour Nicolas");
            Console.WriteLine("------------------" + Environment.NewLine);
            Console.WriteLine("\tBienvenue dans le monde merveilleux du C#");
        }
    }
}
