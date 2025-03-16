﻿using System;
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
        public static string raizCuadrada(double uno)
        {
            if (uno < 0) // Si es negativo, se devuelve la parte imaginaria
            {
                double raiz = Math.Sqrt(-uno); // Se toma el valor absoluto
                return $"{raiz}i"; // Se representa como número imaginario
            }
            else
            {
                return Math.Sqrt(uno).ToString(); // Si es positivo, se devuelve normalmente
            }
        }

        public static double potencia(double uno, double dos)
        {
            double baseNumero = uno;//DEFINIR BASE
            double exponente = dos;//DEFINIR EXPONENTE
            return Math.Pow(baseNumero, exponente);//RETORNAR LA BASE ELEVADA A UN EXPONENTE
        }
        public static double porcentaje(double total, double porcentaje) // Metodo de porcentaje
        {
            return (total * porcentaje) / 100;
        }

        public static double fraccion(double num)
        {
            if (num == 0)
            {
                Console.WriteLine("Error: No se puede calcular la fracción de cero.");
                return double.NaN;
            }
            return 1 / num;
        }
        /// Calcula el seno de un ángulo en radianes.
        public static double Seno(double uno)
        {
            return Math.Sin(uno);
        }

        /// Calcula el coseno de un ángulo en radianes
        public static double Coseno(double uno)
        {
            return Math.Cos(uno);
        }
    }
}