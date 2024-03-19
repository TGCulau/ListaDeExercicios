namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Cor
                Console.ForegroundColor = ConsoleColor.Magenta;

                Home();

                string opm = LerString("\nQual unidade de medida deseja usar?\n1. Cm³\n2. M³\n\nDigite sua opção: ");
                CheckOP(opm);

                //Dados
                Home();
                decimal comp = LerDecimal("\nDigite o valor do comprimento: ");
                decimal larg = LerDecimal("\nDigite o valor da largura: ");
                decimal alt = LerDecimal("\nDigite o valor da altura: ");

                //Equação
                decimal resultado = Equacao(comp, larg, alt);

                //Resultado
                Home();
                if (opm == "1")
                {
                    Console.WriteLine($"\nO volume calculado foi de {resultado}Cm³.\n\nPrecione qualquer tecla para continuar.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"\nO volume calculado foi de {resultado}M³.\n\nPrecione qualquer tecla para continuar.");
                    Console.ReadLine();
                }

                Home();
                opm = LerString("\nEscolha sua opção. \n1. Calcular outro valor \n2. Sair \n\nDigite sua opção: ");
                CheckOP(opm);

                //Reinicia o programa
                if (opm == "1")
                {
                    continue;
                }
                //Saida
                Exit();
                break;
            }
        }

        private static void Home()
        {
            Console.Clear();
            Console.WriteLine("########################################################################################################################");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                               Academia do programador 2024 - Lista de Exercícios 1                               ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                                    Exercício 1                                                   ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                          Volume de uma caixa retangular                                          ###");
            Console.WriteLine("###                    Para calcular o volume é necessário fornecer comprimento, largura e altura                    ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("########################################################################################################################");
        }

        static decimal LerDecimal(string texto)
        {
            Console.Write(texto);

            decimal LeitorDeDecimal = Convert.ToDecimal(Console.ReadLine());

            return LeitorDeDecimal;
        }

        static string LerString(string texto)
        {
            Console.Write(texto);

            string LeitorDeString = Console.ReadLine();

            return LeitorDeString;
        }

        static void CheckOP(string op)
        {
            while (op != "1" && op != "2")
            {
                Console.Write("\nOpção inválida, escolha uma opção válida entre 1 e 2. \nSua opção: ");
                op = Console.ReadLine();
            }
        }

        static decimal Equacao(decimal comp, decimal larg, decimal alt)
        {
            return comp * larg * alt;
        }
        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("########################################################################################################################");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                               Academia do programador 2024 - Lista de Exercícios 1                               ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                                    Exercício 1                                                   ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("###                                                     Obrigado                                                     ###");
            Console.WriteLine("###                                   Até mais. Precione qualquer tecla para sair.                                   ###");
            Console.WriteLine("###                                                                                                                  ###");
            Console.WriteLine("########################################################################################################################");
            Console.ReadLine();
        }
    }
}
