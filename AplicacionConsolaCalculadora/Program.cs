using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionConsolaCalculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("#1 Sumar");
                Console.WriteLine("#2 Restar");
                Console.WriteLine("#3 Multiplicar");
                Console.WriteLine("#4 Dividir");
                Console.WriteLine("#5 Salir");

                var menu = Console.ReadLine();

                if (menu == "5")
                {
                    break;
                }

                Console.WriteLine("Primer numero:");
                var n1 = Console.ReadLine();
                Console.WriteLine("Segundo numero:");
                var n2 = Console.ReadLine();

                Calculadora calculadora = new Calculadora();

                if (int.TryParse(n1, out int num1) && int.TryParse(n2, out int num2))
                {
                    switch (menu)
                    {
                        case "1":
                            Console.WriteLine($"{calculadora.Sumar(num1, num2)}");
                            break;
                        case "2":
                            Console.WriteLine($"{calculadora.Restar(num1, num2)}");
                            break;
                        case "3":
                            Console.WriteLine($"{calculadora.Multiplicar(num1, num2)}");
                            break;
                        case "4":
                                Console.WriteLine($"{calculadora.Dividir(num1, num2)}");
                            break;
                        default:
                            Console.WriteLine("No es una opcion valida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido.");
                }
            }
        }



    public class Calculadora
        {
            public int Sumar(int a, int b)
            {
                return a + b;
            }

            public int Restar(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }

            public double Dividir(int a, int b)
            {
                return (double)a / b;
            }
        }
    }

 }