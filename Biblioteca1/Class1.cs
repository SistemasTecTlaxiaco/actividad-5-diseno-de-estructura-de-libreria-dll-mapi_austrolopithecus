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
    //Ingreso de colaborador Isaíass
    //ingreso usuario Paola
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

        public static double raizCuadrada(double uno)
        {
            if (uno < 0)//VALIDAR CALCULO DE RAICES NEGATIVAS
            {
                throw new ArgumentException("imposible calcular la raíz cuadrada de un número negativo");
            }
            return Math.Sqrt(uno);//RETORNAR EL VALOR DE LA RAÍZ
        }

        public static double potencia(double uno, double dos)
        {
            double baseNumero = uno;//DEFINIR BASE
            double exponente = dos;//DEFINIR EXPONENTE
            return Math.Pow(baseNumero, exponente);//RETORNAR LA BASE ELEVADA A UN EXPONENTE
        }
    }
}