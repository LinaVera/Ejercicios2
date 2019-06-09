using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class divisible
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero");
            int.TryParse(Console.ReadLine(), out int n1);
            bool res = divisibl(n1);
            Console.WriteLine("El numero {0} es divisible en 5 y 11?:  {1}", n1, res);

        }
        private static bool divisibl(int num) {
            bool res;
            res = ((num % 5 == 0) && (num % 11 == 0)) ? true : false;
            return res;
        }

    }

