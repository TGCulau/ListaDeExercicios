namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                decimal fib, aux = 1, aux2, aux3;
                string opm;

                //Home
                Console.Clear();
                Console.WriteLine("######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                  Exercício 26                                  ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                    Fibonacci                                   ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");

                //Dados
                Console.Write("\nDigite o valor alvo da sequencia de Fibonacci: ");
                fib = Convert.ToDecimal(Console.ReadLine());

                if (fib == 0 || fib < 2)
                {
                    Console.Write($"\nO valor solicitado {fib} não corresponde a um numero Fibonacci. Por favor, verifique o numero digitado. É necessário que o numero seja pelo menos maior que 2.\n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    continue;
                }

                //Equação
                aux2 = aux; 
                aux3 = aux + aux2;

                Console.Write("\nA sequencia é: 1  1  2 ");
                while (true)
                {
                    if(fib > aux2)
                    {
                        aux2 = aux3 + aux2;
                        if (aux2 <= fib)
                        {
                            Console.Write($" {aux2} ");
                        }
                        if (fib > aux2)
                        {
                            aux3 = aux3 + aux2;
                            if(aux3 <= fib)
                            {
                                Console.Write($" {aux3} ");
                            }
                            continue;
                        }
                        continue;
                    }
                    break;
                } 
                if(aux3 != fib && aux2 != fib)
                {
                    Console.Write($"\nO valor solicitado {fib} não corresponde a um numero Fibonacci. Por este motivo o programa imprimiu apenas até o numero mais proximo.");
                }
                else
                {
                    Console.Write($"\nO valor solicitado {fib} corresponde a um numero Fibonacci. Por este motivo o programa imprimiu a sequencia até o numero solicitado.");
                }
                
                //Menu
                while (true)
                {
                    Console.Write("\n\nEscolha sua opção. \n1. Calcular outro valor \n2. Sair \nDigite sua opção: ");
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
                    Console.WriteLine("###                                  Exercício 26                                  ###");
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
