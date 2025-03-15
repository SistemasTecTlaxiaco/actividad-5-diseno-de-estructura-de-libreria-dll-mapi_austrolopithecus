using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace My_library
{
   
        public class Calculadora
        {
            public static double sumar(double uno, double dos)
            {
                return uno + dos;
            }

            public static double multiplicar(double uno, double dos)
            {
                return uno * dos;
            }

            public static double restar(double uno, double dos)
            {
                return uno - dos;
            }

            public static double Dividir(double uno, double dos)
            {
                if (dos == 0) {
                    Console.WriteLine("Error No se puede dividir entre 0 ");
                    return 0;
                } 
                else { 
                    return uno / dos; 
                }
                
            }

        



        }

    
}
