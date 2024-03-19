namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Variáveis
            decimal peso, altura, IMC, auxIMC = 185;
            string nome, IMCF;

            //Home
            Home();

            //Dados
            Console.Write("\nQual seu nome? ");
            nome = Console.ReadLine();

            Console.Write("\nQuantos quilos você pesa? ");
            peso = Convert.ToDecimal(Console.ReadLine());            

            Console.Write("\nQual sua altura? ");
            altura = Convert.ToDecimal(Console.ReadLine());
            if (altura > 100)
            {
                altura = altura / 100;
            }

            //Equação
            altura = altura * altura;
            IMC = peso / altura;
            auxIMC = auxIMC / 10;
            IMCF = IMC.ToString("F2");
            //Resultado
            Home();
            if (IMC < auxIMC)
            {
                Console.WriteLine($"\n{nome}, seu IMC é de: {IMCF}. \nVocê está abaixo do peso! Procure um médico!\n\n");
            }

            else if (IMC > auxIMC && IMC < 25)
            {
                Console.WriteLine($"\n{nome}, seu IMC é de: {IMCF}. \nParabéns, você está com seu peso ideal.\n\n");
            }

            else if (IMC > 25 && IMC < 30)
            {
                Console.WriteLine($"\n{nome}, seu IMC é de: {IMCF}. \nVocê está acima do peso! Procure fazer uma dieta!\n\n");
            }

            else if (IMC > 30)
            {
                Console.WriteLine($"\n{nome}, seu IMC é de: {IMCF}. \nVocê está obeso! Procure um médico!\n\n");
            }

            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 19                                  ###");
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
            Console.WriteLine("###                                  Exercício 19                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                      IMC                                       ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
        }
    }
}
