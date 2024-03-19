namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                int a, b, c, aux;
                string opm;

                //Home
                Console.Clear();
                Console.WriteLine("######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                  Exercício 18                                  ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");

                //Dados
                Console.Write("\nDigite 3 numeros inteiros diferentes para ordenação.\n\nDigite o valor de A: ");
                a = Convert.ToInt32(Console.ReadLine());

                while (true)
                {
                    Console.Write("\nDigite o valor de B: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b == a)
                    {
                        Console.WriteLine("\nOpção inválida, digite um numero diferente do digitado anteriormente. \n\nPrecione qualquer tecla para continuar.\n");
                        Console.ReadLine();
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.Write("\nDigite o valor de C: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    if (c == a)
                    {
                        Console.WriteLine("\nOpção inválida, digite um numero diferente do digitado no valor de A. \n\nPrecione qualquer tecla para continuar.\n\n");
                        Console.ReadLine();
                        continue;
                    }

                    if (c == b)
                    {
                        Console.WriteLine("\nOpção inválida, digite um numero diferente do digitado no valor de B. \n\nPrecione qualquer tecla para continuar.\n\n");
                        Console.ReadLine();
                        continue;
                    }
                    break;
                }

                //Resultado
                if (a > b)
                {
                    aux = a;
                    a = b;
                    b = aux;
                }

                if (b > c)
                {
                    aux = b;
                    b = c;
                    c = aux;
                }

                if (a > b)
                {
                    aux = a;
                    a = b;
                    b = aux;
                }

                Console.WriteLine($"\nA ordem decrescente é {c}, {b} e {a}");
                
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
                    Console.WriteLine("###                                  Exercício 18                                  ###");
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
