namespace Exercicio13Remaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Cabecalho();

                //Dados
                decimal kctinho = LerDecimal("\nDigite a quantia de cacetinhos vendidos: ");
                decimal broa = LerDecimal("\nDigite a quantia de broas vendidas: ");

                //Equação
                equacao(kctinho, broa);

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
            Console.WriteLine("###                              Controle de finanças                              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                 Padaria Hotpão                                 ###");
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
        private static void equacao(decimal kctinho, decimal broa)
        {
            decimal lucro = (kctinho * 0.12m) + (broa * 1.50m);
            decimal poup = lucro * 0.1m;
            Cabecalho();
            Console.WriteLine($"\nO total arrecadado foi de R${lucro}.\nVocê deve depositar na poupança o valor de R${poup}.\n\n");
        }
        static int Rexit()
        {
            int op;
            while (true)
            {
                op = LerInt("\nEscolha sua opção. \n1. Calcular outros valores \n2. Sair \nDigite sua opção: ");

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
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                          Academia do programador 2024                          ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                              Controle de finanças                              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                 Padaria Hotpão                                 ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
