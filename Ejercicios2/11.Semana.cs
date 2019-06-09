using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class Semana
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de la semana");
            int.TryParse(Console.ReadLine(), out int ns);
            string res = diaSemana(ns);
            Console.WriteLine("El numero {0} equivale al dia de la semana:   {1}", ns, res);

        }
        private static string diaSemana(int num)
        {
            string res;
            switch (num)
            {
                case 1:
                    res = "Domingo";
                    break;
                case 2:
                    res = "Lunes";
                    break;
                case 3:
                    res = "Martes";
                    break;
                case 4:
                    res = "Miercoles";
                    break;
                case 5:
                    res = "Jueves";
                    break;
                case 6:
                    res = "Viernes";
                    break;
                case 7:
                    res = "Sabado";
                    break;
                default:
                    res = "No ingreso un rago valido";
                    break;
            }
            return res;
        }
    }
}
