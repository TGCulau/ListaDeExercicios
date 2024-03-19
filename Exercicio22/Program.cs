namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Variáveis
            decimal aux, aux2, cont;

            //Home
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 22                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                    Imprimindo numeros impares de 100 a 200                     ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################\n\n");

            //Dados
            aux = 100;

            //Equação e Resultado
            for (cont = 0; cont < 100; cont++)
            {
                aux2 = aux % 2;
                if (aux2 != 0)
                {
                    if (cont == 99)
                    {
                        Console.Write($"{aux}.");
                    }
                    else
                    {
                        Console.Write($"{aux}, ");
                    }
                }
                aux++;
            }

            //Saida
            Console.WriteLine("\n\n######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 22                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
