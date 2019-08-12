using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class VocalConsonante
    {
        private static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Ingrese caracter");
            char.TryParse(Console.ReadLine(),out letra);
            caracter(letra);
        }
        private static void caracter(char l)
        {
            if (l=='a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')
            {
                Console.WriteLine("Es una vocal");
            }
            else { Console.WriteLine("Es una consonante"); }
              
        }
    }
}
