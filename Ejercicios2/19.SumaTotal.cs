using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class sumaTotla
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingresar n");
            int.TryParse(Console.ReadLine(), out int n);
            int res = suma(n);
            Console.WriteLine("La suma es: {0}", res);

        }
        private static int suma(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n>0) {
                    Console.WriteLine(i);
                    suma += i;
                }
            }

            return suma;
        }

    }
}
