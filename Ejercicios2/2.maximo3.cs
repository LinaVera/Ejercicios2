using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class maximo3 {
        private static void Main(string[] args) {

            Console.WriteLine("ingrese numero 1");
            int.TryParse(Console.ReadLine(), out int n1);
            Console.WriteLine("ingrese numero 2");
            int.TryParse(Console.ReadLine(), out int n2);
            Console.WriteLine("ingrese numero 3");
            int.TryParse(Console.ReadLine(), out int n3);

            int res = Maximo3(n1, n2, n3);
            Console.WriteLine("El maximo de los tres numeros es:  {0}", res);
        }
        private static int Maximo3(int n1, int n2, int n3)
        {
            int res;
            if ((n1 > n2) && (n1 > n3)){ res = n1; }
            else if (n2>n3) { res = n2; }
            else { res = n3; }
            return res;
        }
    }

