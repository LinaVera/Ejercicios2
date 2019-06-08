using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class Mes {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero del mes del año 2019");
            int.TryParse(Console.ReadLine(), out int ns);
            diasMes(ns);

        }
        private static void diasMes(int num)
        {

            switch (num)
            {
                case 1:
                    Console.WriteLine("Mes: Enero, #Dias: 31");
                    break;
                case 2:
                    Console.WriteLine("Mes: Febrero, #Dias: 28");
                    break;
                case 3:
                    Console.WriteLine("Mes: Marzo, #Dias: 31");
                    break;

                case 4:
                    Console.WriteLine("Mes: Abril, #Dias: 30");
                    break;
                case 5:
                    Console.WriteLine("Mes: Mayo, #Dias: 31");
                    break;
                case 6:
                    Console.WriteLine("Mes: Junio, #Dias: 30");
                    break;
                case 7:
                    Console.WriteLine("Mes: Julio, #Dias: 31");
                    break;
                case 8:
                    Console.WriteLine("Mes: Agosto, #Dias: 31");
                    break;
                case 9:
                    Console.WriteLine("Mes: Septiembre, #Dias: 30");
                    break;
                case 10:
                    Console.WriteLine("Mes: Octubre, #Dias: 31");
                    break;
                case 11:
                    Console.WriteLine("Mes: Noviembre, #Dias: 30");
                    break;
                case 12:
                    Console.WriteLine("Mes: Diciembre, #Dias: 31");
                    break;
                default:

                    Console.WriteLine("Numero fuera de rango");
                    break;

            }
        }
    }
}
