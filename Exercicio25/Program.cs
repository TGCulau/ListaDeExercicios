namespace Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                decimal fat, aux, aux2 = 1;
                int cont;
                string opm;

                //Home
                Console.Clear();
                Console.WriteLine("######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                  Exercício 25                                  ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                    Taboada                                     ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");

                //Dados
                Console.Write("\nDigite o valor do fatorial a ser calculado: ");
                fat = Convert.ToDecimal(Console.ReadLine());
                aux = fat;

                //Resultado
                Console.Write($"\nO fatoral de {fat} é: {fat}! =");
                for (cont = 1; cont <= fat; cont++)
                {
                    aux2 *= aux;
                    
                    if(cont < fat)
                    {
                        Console.Write($" {aux} x");
                    }
                    else if (cont <= fat)
                    {
                        Console.Write($" {aux} = {aux2}");
                    }
                    aux--;
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
                    Console.WriteLine("###                                  Exercício 25                                  ###");
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
