using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class NegativoPositivoCero
    {
        private static void Main(string[] args) {
            Console.WriteLine("Ingrese numero");
            int.TryParse(Console.ReadLine(), out int n1);
            string res = definicion(n1);
            Console.WriteLine("El nuemro {0} es:  {1}", n1, res);

        }
        private static string definicion(int num)
        {
            String res;
            res = (num == 0) ? "El número es cero" :
                (num > 0) ? "El número es positivo" : "El número es negativo";
            return res;
        }
    }
}
