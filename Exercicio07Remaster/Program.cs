namespace Exercicio7Remaster
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
                decimal sb = LerDecimal("\nInforme o seu salário base: R$");
                decimal tv = LerDecimal("\nInforme o seu total de vendas: ");
                decimal pc = LerDecimal("\nInforme o percentual de comissão: ");

                pc = Equacao(tv, pc);

                //Resultado
                Console.WriteLine($"\nO seu salário bruto será de R${pc + sb}. Sendo R${pc} apenas de comissões.");

                op = Rexit();
            }
            Exit();
        }
        static void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                   Exercício 7                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                               Folha de pagamento                               ###");
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
        static decimal Equacao(decimal tv, decimal pc)
        {
            pc /= 100;
            pc = tv * pc;
            return pc;
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
            Console.WriteLine("###                                   Exercício 7                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
