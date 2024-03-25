namespace Exercicio9Remaster
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

                int tdn = LerInt("\nInforme a quantia de notas que serão somadas: ");
                double[] n = new double[tdn];
                int aux = 0;
                int aux2 = 0;
                while (aux < tdn)
                {
                    aux2 = aux + 1;
                    Console.Write($"\nInforme o valor da {aux2}ª nota: ");
                    n[aux] = Convert.ToDouble(Console.ReadLine());
                    aux++;
                }

                //Equação
                double soma = 0, res;
                for (int cont = 0; cont < tdn; cont++)
                {
                    soma += 1 / n[cont];
                }
                res = tdn / soma;

                //Resultado
                string resf = res.ToString("F2");
                Console.WriteLine($"\nA média harmônica das notas será {resf}.");

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
            Console.WriteLine("###                                   Exercício 9                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                            Média harmônica das notas                           ###");
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
            Console.WriteLine("###                                   Exercício 9                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
