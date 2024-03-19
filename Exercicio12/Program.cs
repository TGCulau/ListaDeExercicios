namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                decimal area, comp, larg;
                string opm, opu;

                //Home
                Console.Clear();
                Console.WriteLine("######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                          Academia do programador 2024                          ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                               Cálculo de terreno                               ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                              Imobiliária Imóbilis                              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");

                //Unidade de medida
                while (true)
                {
                    Console.Write("\nQual unidade de medida deseja usar?\n1. M²\n2. Km²\nDigite sua opção: ");
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
                Console.Write("\nDigite o valor do comprimento: ");
                comp = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nDigite o valor da largura: ");
                larg = Convert.ToDecimal(Console.ReadLine());

                //Equação
                area = comp * larg;

                //Resultado
                if (opu == "1")
                {
                    Console.WriteLine($"\nO volume calculado foi de {area}M².");
                }
                else
                {
                    Console.WriteLine($"\nO volume calculado foi de {area}Km².");
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
                    Console.WriteLine("###                          Academia do programador 2024                          ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###                               Cálculo de terreno                               ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###                              Imobiliária Imóbilis                              ###");
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
