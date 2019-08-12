using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class MaximoMinimoArray
    {
        private static void Main(string[] args)
        {
            int[] arra=llenar();
            compara(arra);

        }
        public static int[] llenar() {
            int[] arra =new  int [5];
            for(int i = 0; i <= arra.Length; i++)
            {
                Console.WriteLine("Ingrese dato:  " +i);
                int.TryParse(Console.ReadLine(), out int ns);
                arra[i] = ns;

            }
            return arra;
        }
        public static void compara(int[] array)
        {
            int max, min;
            max = min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("El minimo es: "+min);
            Console.WriteLine("El máximo es: " + max);
        }

    }

}
