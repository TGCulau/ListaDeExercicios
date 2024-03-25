namespace Exercicio12Remaster
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
                //Unidade de medida
                int opm = UnidadeMedida();
                Cabecalho();
                //Dados
                decimal comp = LerDecimal("\nDigite o valor do comprimento: ");

                decimal larg = LerDecimal("\nDigite o valor da largura: ");
                Cabecalho();
                //Resultado
                if (opm == 1)
                {
                    Console.WriteLine($"\nO volume calculado foi de {comp * larg}M².");
                }
                else
                {
                    Console.WriteLine($"\nO volume calculado foi de {comp * larg}Km².");
                }

                op = Rexit();
            }
            Exit();
        }
        private static void Cabecalho()
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
        static int UnidadeMedida()
        {
            int op;
            while (true)
            {
                op = LerInt("\nQual unidade de medida deseja usar?\n1. M²\n2. Km²\nDigite sua opção: ");
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
            Console.WriteLine("###                                  Exercício 10                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
