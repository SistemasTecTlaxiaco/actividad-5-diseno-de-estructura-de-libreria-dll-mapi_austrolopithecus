using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca1;

//ingreso de usuario Ariadna 
//ingreso de usuario Paola
// Ingreso de Usuario Mayra

namespace Calculadora_Austrolopithecus
{
        class Program
        {
            private static double num1 = 0, num2 = 0, num0 = 0;
            static void Main(string[] args)
            {
                bool salir = false;
                while (!salir)
                {
                    try
                    {
                        Console.WriteLine(" Menu Principal de Calculadora del Tecnologico de Tlaxiaco");
                        Console.WriteLine("1. Sumar dos numeros");
                        Console.WriteLine("2. Restar dos numeros");
                        Console.WriteLine("3. Multiplicar");
                        Console.WriteLine("4. Dividir");
                        Console.WriteLine("5. Raiz Cuadrada");
                        Console.WriteLine("6. Potencia");
                        Console.WriteLine("7. Porcentaje");
                        Console.WriteLine("8. Fraccion");
                        Console.WriteLine("9. Salir");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Elige una de las opciones");
                        int opcion = Convert.ToInt32(Console.ReadLine());

                        switch (opcion)
                        {
                            case 3:
                                teclado1();
                                Console.WriteLine("El resultado de la Multiplicacion es: " + Class1.multiplicar(num1, num2));
                                break;
                            case 4:
                                teclado1();
                                Console.WriteLine("El resultado de la Division es: " + Class1.dividir(num1, num2));
                                break;
                            case 9:
                                Console.WriteLine("Has elegido salir de la aplicación");
                                Environment.Exit(1);
                                salir = true;
                                break;
                            default:
                                Console.WriteLine("Elige una opcion entre 1 y 9");
                                break;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Error al ingresar!!");
                    }
                }
            }

            private static void teclado0()
            {
                Console.WriteLine("Introduzca un numero");
                num0 = double.Parse(Console.ReadLine());
            }
            private static void teclado1()
            {
                Console.WriteLine("Introduzca el primer numero");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo numero");
                num2 = double.Parse(Console.ReadLine());
            }
        }

    }

