namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                decimal a, b, c, aux;
                string opm;

                //Home
                Console.Clear();
                Console.WriteLine("######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                  Exercício 17                                  ###");
                Console.WriteLine("###                                                                                ###"); 
                Console.WriteLine("######################################################################################");

                //Dados
                Console.Write("\nDigite o valor de A: ");
                a = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nDigite o valor de B: ");
                b = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nDigite o valor de C: ");
                c = Convert.ToDecimal(Console.ReadLine());

                //Equação
                aux = a + b;

                //Resultado
                if (aux < c)
                {
                    Console.WriteLine($"\nO valor de {a} + {b} é {aux} que é menor que {c}.");
                }
                else if (aux > c)
                {
                    Console.WriteLine($"\nO valor de {a} + {b} é {aux} que é maior que {c}.");
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
                    Console.WriteLine("###                                  Exercício 17                                  ###");
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
