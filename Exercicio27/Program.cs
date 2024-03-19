using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;

namespace Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Variáveis
            decimal aux, aux2, aux3, cont, cont2 = 0;

            //Home
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 27                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    FizzBuzz                                    ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################\n\n");

            //Dados
            aux = 1;

            //Equação e Resultado
            for (cont = 0; cont < 100; cont++)
            {
                aux2 = aux % 3;
                if (cont == 99)
                {
                    if (aux2 == 0)
                    {
                        Console.Write(" Fizz.");
                    }

                    aux3 = aux % 5;
                    if (aux3 == 0)
                    {
                        Console.Write(" Buzz.");
                    }

                    else if (aux2 == 0 && aux3 == 0)
                    {
                        Console.Write(" FizzBuzz.");
                    }

                    else if (aux2 != 0 && aux3 != 0)
                    {
                        Console.Write($" {aux}.");
                    }
                }

                else if (cont < 99)
                {
                    if (aux2 == 0)
                    {
                        Console.Write(" Fizz,");
                    }

                    aux3 = aux % 5;
                    if (aux3 == 0)
                    {
                        Console.Write(" Buzz,");
                    }

                    else if (aux2 == 0 && aux3 == 0)
                    {
                        Console.Write(" FizzBuzz,");
                    }

                    else if (aux2 != 0 && aux3 != 0)
                    {
                        Console.Write($" {aux},");
                    }
                    aux++;
                }
            }

            //Saida
            Console.WriteLine("\n\n######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 27                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}