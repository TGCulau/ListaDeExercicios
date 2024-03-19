namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                //Variáveis
                decimal kctinho, pkctinho = 12, broa, pbroa = 150, lucro, aux, porc = 10;
                double poup;

                //Home
                Home();


                //Dados
                Console.Write("\nDigite a quantia de cacetinhos vendidos: ");
                kctinho = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nDigite a quantia de broas vendidas: ");
                broa = Convert.ToDecimal(Console.ReadLine());

                //Equação
                pkctinho = pkctinho / 100;
                pbroa = pbroa / 100;
                lucro = (kctinho * pkctinho) + (broa * pbroa);
                porc = porc / 100;
                aux = lucro * porc;
                poup = Convert.ToDouble(aux);

                //Resultado
                Home();
                Console.WriteLine($"\nO total arrecadado foi de R${lucro}.\nVocê deve depositar na poupança o valor de R${poup}.\n\n");
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

        private static void Home()
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
    }
}
