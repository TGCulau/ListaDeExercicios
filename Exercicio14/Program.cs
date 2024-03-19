namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Variáveis
            decimal idade, dias;
            string nome;

            //Home
            Home();

            //Dados
            Console.Write("\nQual seu nome? ");
            nome = Console.ReadLine();

            Console.Write("\nQuantos anos você tem? ");
            idade = Convert.ToDecimal(Console.ReadLine());

            //Equação
            dias = idade * 365;

            //Resultado
            Home();
            Console.WriteLine($"\n{nome}, você já viveu {dias} dias!!\n\n");
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 14                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }

        private static void Home()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 14                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Dias de vida                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
        }
    }
}
