using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class maximo
    {
        private static void Main(string[] args) {
            Console.WriteLine("ingrese numero 1");
            int.TryParse(Console.ReadLine(), out int n1);
            Console.WriteLine("ingrese numero 2");
            int.TryParse(Console.ReadLine(), out int n2);
            int res = Maximo(n1, n2);
            Console.WriteLine("El maximo de los dos numeros es:  {0}", res);
        }
        private static int Maximo(int n1, int n2)
        {
            int res;
            res = (n1 > n2) ? n1 : n2;
            return res;
        }
    }
}
