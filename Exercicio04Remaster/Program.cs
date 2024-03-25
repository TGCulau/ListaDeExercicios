namespace Exercicio4Remaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Cabecalho();

                //Dados
                decimal kmi = LerDecimal("\nDigite a quilometragem inicial: ");
                decimal kmf = LerDecimal("\nDigite a quilometragem final: ");
                decimal cc = LerDecimal("\nDigite o consumo de combustível: ");
                op = Check();

                //Equação
                decimal kml = Equacao(kmi, kmf, cc);

                Cabecalho();

                //Resultados
                Console.WriteLine($"\nDistancia percorrida total de {kmi - kmf}Km e seu consumo foi de {kml}Kml.");
                Consumo(op, kml);

                //Menu
                op = Rexit();
            }
            Exit();
        }

        private static void Consumo(int op, decimal kml)
        {
            if (op == 1)
            {
                if (kml > 7)
                {
                    Console.WriteLine("\nParabéns, seu veículo é economico!");
                }
                else
                {
                    Console.WriteLine("\nLamento, seu veículo está gastando muito! Considere fazer uma manutenção ou reveja seu modo de conduzir!");
                }
            }

            else if (op == 2)
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
        }

        static int Check()
        {
            int op;
            while (true)
            {
                op = LerInt("\nEsta aferição foi em:\n1. Cidade\n2. Estrada\nSua opção: ");

                //Validação menu
                if (op != 1 && op != 2)
                {
                    Console.WriteLine("\nOpção inválida, escolha uma opção válida entre 1 e 2. \n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
            return op;
        }
        static void Cabecalho()
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
        static int LerInt(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = int.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }

                Console.Write("\nPor favor digite um numero.\n\nPrecione qualquer tecla para continuar.");
                Console.ReadLine();
                Cabecalho();
            }
        }
        static decimal LerDecimal(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = decimal.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }

                Console.Write("\nPor favor digite um numero.\n\nPrecione qualquer tecla para continuar.");
                Console.ReadLine();
                Cabecalho();
            }
        }
        static decimal Equacao(decimal kmi, decimal kmf, decimal cc)
        {
            decimal kml = (kmf - kmi) / cc;
            return kml;
        }
        static int Rexit()
        {
            int op;
            while (true)
            {
                op = LerInt("\nEscolha sua opção. \n1. Calcular outro valor \n2. Sair \nDigite sua opção: ");

                if (op != 1 && op != 2)
                {
                    Console.WriteLine("\nOpção inválida, escolha uma opção válida entre 1 e 2. \n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
            return op;
        }
        static void Exit()
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
        }
    }
}
