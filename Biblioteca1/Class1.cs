using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Class1
    //ingreso usuario Ariadna
    // Ingreso usuario Mayra 
    //Ingreso de colaborador Isaías
    {
        public static double sumar(double uno, double dos)
        {
            return uno + dos;
        }

        public static double restar(double uno, double dos)
        {
            return uno - dos;
        }

        public static double multiplicar(double uno, double dos)
        {
            return uno * dos;
        }

        public static double dividir(double uno, double dos)
        {
            if (dos != 0)
            {
                return uno / dos;
            }
            else
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }
        }
    }
}