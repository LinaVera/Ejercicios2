using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class ParFunciones
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero");
            int.TryParse(Console.ReadLine(), out int n1);

            bool res = par(n1);
            Console.WriteLine("El numero {0} es par?:  {1}", n1, res);
        }
        private static bool par(int nu)
        {
            bool res;
            res = (nu % 2 == 0) ? true : false;
            return res;
        }
    }
}
