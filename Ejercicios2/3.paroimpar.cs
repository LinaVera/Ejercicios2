﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class paroimpar
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero");
            int.TryParse(Console.ReadLine(), out int n1);

            bool res = res = (n1 % 2 == 0) ? true : false;
            Console.WriteLine("El numero {0} es par?:  {1}", n1, res);
        }
    }
}
