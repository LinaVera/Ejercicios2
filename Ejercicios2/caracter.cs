using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class caracter {
        private static void Main(string[] args) {
            Console.WriteLine("ingrese un caracter");
            if (!char.TryParse(Console.ReadLine(), out char n)) {
                Console.WriteLine("Si es un caracter");
            }
            else {
                Console.WriteLine("No es un caracter");
            }
        }
        
    }
}
