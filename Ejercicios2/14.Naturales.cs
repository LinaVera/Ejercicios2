using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class Naturales
    {
        private static void Main(string[] args) {
            Console.WriteLine("Ingresar n");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine("");
            naturales(n);
        }
        private static int natural(int n) {
            int suma=0, i=0;
            if (n > 0)
            {
                while (i <= n)
                {
                    suma += i;
                    i++;
                }
            }
            else {
                Console.WriteLine("N no es un numero natural");
            }
            return suma;
        }
        public static void naturales(int n)
        {
            int i = 1;
            if (n>0) {
                while (i <= n)
                {
                    Console.WriteLine(i++);
                }
            }
        }
        

    }
}
