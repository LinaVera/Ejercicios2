using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class año
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ingrese año");
            int.TryParse(Console.ReadLine(), out int n1);

            bisi(n1);
        }
        private static void bisi(int num)
        {
            if ((num % 4 == 0) && ((num % 100 != 0) || (num % 400 == 0)))  {
                Console.WriteLine("El año es bisiesto");

            }
            else {
                Console.WriteLine("El año no es bisiesto");
            }
        }
    }
}
