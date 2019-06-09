using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class Alfabeto
    {
        static void Main(string[] args)
        {
            char letra = 'a';

            while (letra <= 'z')
            {
                Console.Write("- {0}", letra);

                letra++;

            }

            Console.ReadLine();

        }

    }
}
