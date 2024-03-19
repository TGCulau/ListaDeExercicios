namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                decimal kmi, kmf, kmm, kml, cc;
                string op = "";
                string opm = "";
                string opu = "";

                //Home
                Home();

                //Dados
                Console.Write("\nDigite a quilometragem inicial: ");
                kmi = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nDigite a quilometragem final: ");
                kmf = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nDigite o consumo de combustível: ");
                cc = Convert.ToDecimal(Console.ReadLine());

                while (true)
                {
                    Console.Write("\nEsta aferição foi em:\n1. Cidade\n2. Estrada\nSua opção: ");
                    op = Console.ReadLine();

                    //Validação menu
                    if (op != "1" && op != "2")
                    {
                        Console.WriteLine("\nOpção inválida, escolha uma opção válida entre 1 e 2. \n\nPrecione qualquer tecla para continuar.\n");
                        Console.ReadLine();
                        continue;
                    }
                    break;
                }

                //Equação
                kmm = kmf - kmi;
                kml = kmm / cc;

                Home();

                //Resultados
                Console.WriteLine($"\nDistancia percorrida total de {kmm}Km e seu consumo foi de {kml}Kml.");
                
                if(op == "1")
                {
                    if(kml > 7)
                    {
                        Console.WriteLine("\nParabéns, seu veículo é economico!");
                    }
                    else
                    {
                        Console.WriteLine("\nLamento, seu veículo está gastando muito! Considere fazer uma manutenção ou reveja seu modo de conduzir!");
                    }
                }

                else if (op == "2")
                {
                    if (kml > 14)
                    {
                        Console.WriteLine("\nParabéns, seu veículo é economico!");
                    }
                    else
                    {
                        Console.WriteLine("\nLamento, seu veículo está gastando muito! Considere fazer uma manutenção ou reveja seu modo de conduzir!");
                    }
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
                    Console.WriteLine("###                                   Exercício 4                                  ###");
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

        private static void Home()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                   Exercício 4                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                        Calculo de consumo de combustivel                       ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###         Para calcular o consumo é necessário fornecer km inicial, final        ###");
            Console.WriteLine("###                             e o consumo em litros.                             ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
        }
    }
}
