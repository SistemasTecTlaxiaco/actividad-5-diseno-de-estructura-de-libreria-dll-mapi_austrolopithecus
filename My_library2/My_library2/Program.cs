using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_library;

namespace My_library2
{
    internal class Program

    {
        private static double n1 = 0, n2 = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzaca el 2do numero");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado de la suma es :" + Calculadora.restar(n1, n2));
            Console.ReadKey();


        }
    }
}
