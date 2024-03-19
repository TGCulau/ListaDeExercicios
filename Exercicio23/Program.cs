namespace Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Variáveis
            decimal aux, aux2, aux3, cont, cont2 = 0;

            //Home
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 23                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###             Imprimindo numeros impares multiplos de 3 entre 1 a 500            ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################\n\n");

            //Dados
            aux = 1;

            //Equação e Resultado
            for (cont = 0; cont < 500; cont++)
            {
                aux2 = aux % 2;
                if (aux2 != 0)
                {
                    aux3 = aux % 3;
                    if (aux3 == 0)
                    {
                        cont2 += aux;
                        if (cont == 494)
                        {
                            Console.Write($"{aux}.");
                        }
                        else
                        {
                            Console.Write($" {aux}, ");
                        }
                    }
                }
                aux++;
            }
            Console.WriteLine($"\n\nO total somado de numeros impares e multiplos de 3 no intervalo de 1 até 500 é de {cont2}.");

            //Saida
            Console.WriteLine("\n\n######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 23                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
