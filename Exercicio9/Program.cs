namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                int tdn, aux = 0, aux2;
                double soma = 0, res;
                string opm = "";

                //Home
                Console.Clear();
                Console.WriteLine("######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                   Exercício 9                                  ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                            Média harmônica das notas                           ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");

                //Dados
                Console.Write("\nInforme a quantia de notas que serão somadas: ");
                tdn = Convert.ToInt32(Console.ReadLine());
                double[] n = new double[tdn];
                
                while (aux < tdn)
                {
                    aux2 = aux + 1;
                    Console.Write($"\nInforme o valor da {aux2}ª nota: ");
                    n[aux] = Convert.ToDouble(Console.ReadLine());
                    aux++;
                }

                //Equação               
                for (int cont = 0;  cont < tdn;  cont++)
                {
                    soma += 1 / n[cont];  
                }
                res = tdn / soma;
                


                //Resultado
                Console.WriteLine($"\nA média harmônica das notas será {res}.");

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
                    Console.WriteLine("###                                   Exercício 9                                  ###");
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
