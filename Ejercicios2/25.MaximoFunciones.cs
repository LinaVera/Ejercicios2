using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class MaximoFunciones
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero 1");
            int.TryParse(Console.ReadLine(), out int n1);
            Console.WriteLine("ingrese numero 2");
            int.TryParse(Console.ReadLine(), out int n2);
            int res = Maximo(n1, n2);
            int res2 = Minimo(n1, n2);
            Console.WriteLine("El maximo de los dos numeros es:  {0}", res);
            Console.WriteLine("El minimo de los dos numeros es:  {0}", res2);
        }
        private static int Maximo(int n1, int n2)
        {
            int res;
            res = (n1 > n2) ? n1 : n2;
            return res;
        }
        private static int Minimo(int n1, int n2)
        {
            int res;
            res = (n1 > n2) ? n1 : n2;
            return res;
        }
    }
}
