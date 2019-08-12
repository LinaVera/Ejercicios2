using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class Fusion
    {
        private static void Main(string[] args)
        {
            int[] arr1, arr2;
            Console.WriteLine("Primero Array");
            arr1 = llenar();
            Console.WriteLine("Segundo Array");
            arr2 = llenar();
            Console.WriteLine("Tercero Array");
            fucionar(arr1,arr2);

        }
        public static int[] llenar()
        {
            int[] arra = new int[5];
            for (int i = 0; i <= arra.Length; i++)
            {
                Console.WriteLine("Ingrese dato:  " + i);
                int.TryParse(Console.ReadLine(), out int ns);
                arra[i] = ns;

            }
            return arra;
        }
        private static void fucionar(int[] a1, int[]a2)
        {
            int[] res = new int[a1.Length + a2.Length];
            a1.CopyTo(res, 0);
            a2.CopyTo(res, a1.Length);
            
            for (int y = 0; y < res.Length; y++)
            {
                Console.WriteLine(res[y]);
            }
        }
        }
}
