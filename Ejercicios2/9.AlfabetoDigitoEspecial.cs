using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class AlfabetoDigitoEspecial
    {
        private static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Ingrese algo: ");
            char.TryParse(Console.ReadLine(), out letra);
            mirar(letra);
        }
        private static void mirar(char l)
        {
            if (Char.IsLetter(l))
            {
                Console.WriteLine("Es una letra del alfabeto");
            }
            else if (Char.IsNumber(l))
            {
                Console.WriteLine("Es un digito");
            }
            else
            {
                Console.WriteLine("Es un caracter especial");
                
            }


        }
    }
}
