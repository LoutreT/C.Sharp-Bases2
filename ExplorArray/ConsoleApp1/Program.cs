﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jours = new string[] { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
            for (int i = 0; i < jours.Length; i++)
            {
                Console.WriteLine(jours[i]);
            }
        }
    }
}
