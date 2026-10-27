using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("\n===== MENU PRINCIPAL =====");
                Console.WriteLine("1. Cuadrado hueco");
                Console.WriteLine("2. Triangulo invertido");
                Console.WriteLine("3. Piramide centrada");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                switch (opcion)
                {
                    case 1:
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if (i == 0 || i == 4 || j == 0 || j == 4)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;
                        }

                    case 2:
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5 - i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }

                    case 3:
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 4 - i; j++)
                                {
                                    Console.Write(" ");
                                }

                                for (int k = 0; k < 2 * i + 1; k++)
                                {
                                    Console.Write("*");
                                }

                                Console.WriteLine();
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Opcion no valida. Elija del 1 al 4.");
                            break;
                        }
                }

            } while (opcion != 4);

            Console.WriteLine("Programa finalizado.");
        }
    }
}
