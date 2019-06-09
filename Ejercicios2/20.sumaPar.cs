using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class sumaPar
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingresar n");
            int.TryParse(Console.ReadLine(), out int n);
            int res = sumapar(n);
            Console.WriteLine("La suma es: {0}", res);

        }
        private static int sumapar(int n)
        {
            int suma = 0;
            for (int i=1; i <= n;i++) {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    suma += i;
                }
            }
           
            return suma;
        }
    }
 }
