using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class MayusculaAlfabeto
    {
        private static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Ingrese letra:");
            char.TryParse(Console.ReadLine(), out letra);
            ver(letra);
        }
        private static void ver(char l)
        {
            if (Char.IsUpper(l))
            {
                Console.WriteLine("Es mayuscula");
            }
            else { Console.WriteLine("Es minuscula");
            }

        }
    }
}
