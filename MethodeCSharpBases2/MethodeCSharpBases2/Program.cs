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
            DireBonjour("Nicolas", 30);
            DireBonjour("Jeremie", 20);
        }

        static void DireBonjour(string prenom, int age)
        {
            Console.WriteLine("Bonjour"+prenom);
            Console.WriteLine("Vous avez "+age+" ans"); /* et maintenant reste à tester dans 
            "Deboguer" et ensuite dans "executer sans debogage." */
        }
    }
}
