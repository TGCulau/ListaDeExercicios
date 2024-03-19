using System.Runtime.Intrinsics.X86;

namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                int a, b, c;
                string opm;

                //Home
                Console.Clear();
                Console.WriteLine("######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                  Exercício 21                                  ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");

                //Dados
                Console.Write("\nDigite o valor de A: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nDigite o valor de B: ");
                b = Convert.ToInt32(Console.ReadLine());

                //Equação e resultado
                if (a == b)
                {
                    c = a + b;
                    Console.WriteLine($"\nO numero {a} e {b} são iguais, então foram somados, resultando em: {c}.");
                }
                else
                {
                    c = a * b;
                    Console.WriteLine($"\nO numero {a} e {b} são diferentes, então foram multiplicados, resultando em: {c}.");
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
                    Console.WriteLine("###                                  Exercício 21                                  ###");
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
