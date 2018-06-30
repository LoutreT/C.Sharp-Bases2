using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Methode3
{
    class Program
    {
        static void Main(string[] args)
        {
            static int SommeCroisee()
            {
                List<int> multiplede3 = new List<int>();   // ici on va remplir la 
                                            // liste de multiplede3 avec ****.Add()

                List<int> multiplede5 = new List<int>();   // ici on va remplir la 
                                             // liste de multiplede5 avec ****.Add()

                // faire une boucle qui démarre à 3 et d’avancer de 3 en 3 jusqu’à 
                // la valeur souhaitée. Et pareil pour les multiples de 5 :

                for (int i = 3; i <= 100; i += 3)    // On itère de 3
                {
                    multiplede3.Add(i);
                }
                for (int i = 5; i <= 100; i += 5)    // On itère de 5
                {
                    multiplede5.Add(i);
                }

                // Ensuite, il sera nécessaire de faire deux boucles imbriquées 
                // afin de déterminer les intersections. C’est-à-dire parcourir 
                // la liste de multiple de 3 et à l’intérieur de cette boucle, 
                // parcourir la liste des multiples de 5. On compare les deux éléments, 
                // s’ils sont égaux, c’est qu’ils sont communs aux deux listes.

                int somme = 0;

                foreach (int elementde3 in multiplede3)
                {
                    foreach (int elementde5 in multiplede5)
                    {
                        if (elementde3 == elementde5)
                            somme += elementde5;
                    }
                    return somme;
                }
            }
        }
    }
}
