using System;

namespace Ejercicios2
{
    class CuboNumero
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número");
            int.TryParse(Console.ReadLine(), out int n);
            int res = cuboN(n);
            Console.WriteLine("El cubo es: " + res);

        }
        public static int cuboN(int n)
        {
            int res;
            res = n * n;
            return res;
        }
    }
}
