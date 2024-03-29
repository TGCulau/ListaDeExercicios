﻿namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                decimal raio, alt, v, pi = 314;
                string opm = "";
                string opu = "";

                //Home
                Console.Clear();
                Console.WriteLine("######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                   Exercício 3                                  ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                        Calculo de volume de um Cilindro                        ###");
                Console.WriteLine("###           Para calcular o volume é necessário fornecer raio e altura           ###");
                Console.WriteLine("###                          Este programa usa Pi = 3,14!                          ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");

                //Unidade de medida
                while (true)
                {
                    Console.Write("\nQual unidade de medida deseja usar?\n1. Cm³\n2. M³\nDigite sua opção: ");
                    opu = Console.ReadLine();

                    //Validação menu
                    if (opu != "1" && opu != "2")
                    {
                        Console.WriteLine("\nOpção inválida, escolha uma opção válida entre 1 e 2. \n\nPrecione qualquer tecla para continuar.\n");
                        Console.ReadLine();
                        continue;
                    }
                    break;
                }


                //Dados
                Console.Write("\nDigite o raio: ");
                raio = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nDigite a altura: ");
                alt = Convert.ToDecimal(Console.ReadLine());

                //Equação
                raio = raio * raio;
                pi = pi / 100;
                v = pi * raio * alt;

                //Resultado
                if (opu == "1")
                {
                    Console.WriteLine($"\nO volume do cilindro é {v}Cm³.");
                }
                else
                {
                    Console.WriteLine($"\nO volume do cilindro é {v}M³.");
                }

                //Menu
                while (true)
                {
                    Console.Write("\nEscolha sua opção. \n1. Calcular outro valor \n2. Sair \nDigite sua opção: ");
                    opm = Console.ReadLine();

                    //Validação menu
                    if (opm != "1" && opm != "2")
                    {
                        Console.WriteLine("\nOpção inválida, escolha uma opção válida entre 1 e 2. \n\nPrecione qualquer tecla para continuar.\n");
                        Console.ReadLine();
                        continue;
                    }
                    break;
                }

                //Reinicia o programa
                if (opm == "1")
                {
                    continue;
                }

                //Saida
                else
                {
                    Console.Clear();
                    Console.WriteLine("######################################################################################");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###                                   Exercício 3                                  ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###                                    Obrigado                                    ###");
                    Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("######################################################################################");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
