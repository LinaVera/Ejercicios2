using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class SumarMatriz
    {
        private static void Main(string[] args)
        {
            int[,] mat;
            mat = llenarMatriz();

        }
        public static int[,] llenarMatriz()
        {
            int[,] res = new int[3,3];
            for (int i = 0; i <= res.Length; i++)
            {
                for (int r = 0; r <= res.Length; r++)
                {
                    Console.Write("Ingrese posicion [" + (i + 1) + "," + (r + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    res[i,r] = int.Parse(linea);

                }


            }
            return res;
        }
        private static void SumaMatriz(int[,] mat)
        {
            int suma=0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {

                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    suma=+  mat[i, j];
                }
                Console.WriteLine("sumatoria de la Fila {0} es {1}", i + 1, suma);
                suma = 0;



            }

        }
    }
}
