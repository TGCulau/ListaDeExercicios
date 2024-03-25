namespace Exercicio3Remaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Cabecalho();

                int op = UnidadeDeMedida();

                //Dados
                double raio = LerDouble("\nDigite o raio: ");
                double alt = LerDouble("\nDigite a altura: ");

                double v = Equacao(raio, alt);
                string vf = v.ToString("F2");
                if (op == 1)
                {
                    Console.WriteLine($"\nO volume do cilindro é {vf}Cm³.");
                }
                else
                {
                    Console.WriteLine($"\nO volume do cilindro é {vf}M³.");
                }

                op = Rexit();

                //Reinicia o programa
                if (op == 1)
                {
                    continue;
                }

                Exit();
                break;
            }
        }
        static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                   Exercício 3                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                        Calculo de volume de um Cilindro                        ###");
            Console.WriteLine("###           Para calcular o volume é necessário fornecer raio e altura           ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
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
        static int UnidadeDeMedida()
        {
            int op;
            while (true)
            {
                op = LerInt("\nQual unidade de medida deseja usar?\n\n1. Cm³\n2. M³\n\nDigite sua opção: ");

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
        static double Equacao(double raio, double alt)
        {
            raio *= raio;
            double v = Math.PI * raio * alt;
            return v;
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
            Console.WriteLine("###                                   Exercício 3                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
