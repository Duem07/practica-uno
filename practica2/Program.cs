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
            Console.Read();
        }

        static int suma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
    }
}
