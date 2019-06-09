using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class pares
    {
        private static void Main(string[] args) { 
        int i = 1;
            Console.WriteLine("Numeros pares de 1 a 100");
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
}
    }
}
