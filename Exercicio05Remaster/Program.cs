namespace Exercicio5Remaster
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
                op = UnidadeMedida();

                //Dados
                double v = LerDouble("\nDigite o raio: ");

                v = Equacao(v);

                //Resultado
                Resultado(op, v);

                //Menu
                op = Rexit();
            }
            Exit();
        }
        private static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                   Exercício 5                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                         Calculo de volume de uma Esfera                        ###");
            Console.WriteLine("###                Para calcular o volume é necessário fornecer raio               ###");
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
        static double LerDouble(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = double.TryParse(Console.ReadLine(), out var numero);

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
                op = LerInt("\nQual unidade de medida deseja usar?\n1. Cm³\n2. M³\nDigite sua opção: ");
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
        private static double Equacao(double raio)
        {
            raio = Math.Pow(raio, 3);
            double aux = 1.333333333333333 * Math.PI * raio;
            return aux;
        }
        private static void Resultado(int op, double v)
        {
            string vf = v.ToString("F2");
            if (op == 1)
            {
                Console.WriteLine($"\nO volume da esfera é {vf}Cm³.");
            }
            else
            {
                Console.WriteLine($"\nO volume da esfera é {vf}M³.");
            }
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
