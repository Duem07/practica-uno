using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(suma(34, 56));
            Console.WriteLine(resta(85, 27));
            Console.WriteLine(multiplica(5, 8));
            Console.Read();
        }

        static int suma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        static int resta(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        static int multiplica(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
    }
}
