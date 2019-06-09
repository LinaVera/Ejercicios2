using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class _22
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingresar n");
            int.TryParse(Console.ReadLine(), out int n);
           tabla(n);
            

        }
        private static void tabla(int num)
        {

            int resultado;
            for (int i = 1; i <= 10; i++)
            {
                resultado = num * i;
                Console.WriteLine(num + " * " + i + " = " + resultado);
                        }

        }
    }
}
