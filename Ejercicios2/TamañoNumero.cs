using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class TamañoNumero
    {
        private static void Main() {
            int res;           
            int.TryParse(Console.ReadLine(), out int a);
            int n =a, cont=0;
            for (int i=0; i>n; i++) { 
                 res = n % 10;
                cont++;
                n = n / 10;
            }
            Console.WriteLine("numero  " + a.ToString() + "\n" + "Cantidad de digitos  " + cont.ToString());
        }

    }
}
