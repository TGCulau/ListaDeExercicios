namespace Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                decimal N, aux = 0, aux2;
                int cont;
                string opm;

                while (true)
                {
                    //Home
                    Console.Clear();
                    Console.WriteLine("######################################################################################");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###                                  Exercício 24                                  ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###                                    Taboada                                     ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("######################################################################################");

                    //Dados
                    Console.Write("\nDigite o valor de qual taboada será calculado entre 1 e 10: ");
                    N = Convert.ToDecimal(Console.ReadLine());

                    //Validação
                    if (N > 10)
                    {
                        Console.WriteLine("\nOpção inválida, escolha uma opção válida entre 1 e 10. \n\nPrecione qualquer tecla para continuar.\n");
                        Console.ReadLine();
                        continue;
                    }
                    break;
                }

                //Resultado
                for (cont = 0; cont < 11; cont++)
                {
                    aux2 = N * aux;
                    Console.Write($"\n{aux} x {N} = {aux2}");
                    aux++;
                }

                //Menu
                while (true)
                {
                    Console.Write("\n\nEscolha sua opção. \n1. Calcular outro valor \n2. Sair \nDigite sua opção: ");
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
                    Console.WriteLine("###                                  Exercício 24                                  ###");
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
