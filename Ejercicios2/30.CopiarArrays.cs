using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class CopiarArrays
    {
        private static void Main(string[] args)
        {
           int[] arra= llenar();
            Console.WriteLine("Array copiado");
            Copiar(arra);
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
        private static void Copiar(int[] arra)
        {
            int[] arry= new int[arra.Length];
            for (int x = 0; x < arra.Length; x++) {
                arra[x] = arry[x];
            }
            for (int y = 0; y < arry.Length; y++)
            {
                Console.WriteLine(arry[y]);
            }
            
        }
        }
}
