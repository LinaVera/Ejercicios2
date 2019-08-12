using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class NaturalesAlReves
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingresar n");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine("");
            reves(n);
        }
        public static void reves(int n)
        {


            int i = n;
            if (n>0) {
                while (i >= 1)
                {

                    Console.WriteLine(i--);
                }
            }
        }

    }
}
