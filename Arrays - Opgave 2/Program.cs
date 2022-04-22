using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fornavne = { "Ib ", "Kim ", "Helle ", "Jens ", "Ove " };
            string[] efternavne = { "Jensen", "Nielsen", "Larsen" };
            // Navne

            Console.WriteLine(fornavne[0]);
            Console.WriteLine(fornavne[4]);
            Console.WriteLine("_________________");
            // Navnene bliver skrevet ud.

            Console.WriteLine("Indtast det første efternavn");
            string input = Console.ReadLine();
            efternavne[0] = input;
            Console.WriteLine("Indtast det næste efternavn");
            input = Console.ReadLine();
            efternavne[1] = input;
            Console.WriteLine("Indtast det sidste efternavn");
            input = Console.ReadLine();
            efternavne[2] = input;

            // Nu har brugeren skrevet et custom navn.
            Console.WriteLine("_________________");

            foreach (string navn in fornavne)
                foreach (string enavn in efternavne)
                    Console.WriteLine(navn + enavn);
            Console.ReadLine();
        }
    }
}
