using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class ParesImparesMatriz
    {
        private static void Main(string[] args)
        {
            int[,] mat;
            mat=llenar();
            pares(mat);
            
        }
        public static int[,] llenar()
        {
            int[,] mat;
            Console.Write("Cuantas fila tiene la matriz:");
            int.TryParse(Console.ReadLine(), out int filas);
            
            Console.Write("Cuantas columnas tiene la matriz:");
            int.TryParse(Console.ReadLine(), out int columnas);

            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese componente:");
                   String linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
            return mat;

        }
        public static void pares(int [,] mat) {
            for (int f = 0; f < mat.GetLength(0); f++) {
                for (int c = 0; c < mat.GetLength(1); c++) {
                    //par
                    if (mat[f,c]%2==0) {
                        
                        Console.WriteLine("Par:  "+mat[f,c]);
                    }
                    else {
                        Console.WriteLine("Impar:  "+mat[f, c]);
                    }
                }
            }


         }
    }
}
