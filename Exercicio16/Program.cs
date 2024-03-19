using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                decimal sl, sb, s, imposto = 8, aumento = 15;
                string sf, aumentof, sbf, slf, impostof;

                //Home
                Home();

                //Dados
                Console.Write("\nInforme o seu salário: R$");
                s = Convert.ToDecimal(Console.ReadLine());

                //Equação
                imposto = imposto / 100;
                aumento = aumento / 100;

                aumento = s * aumento;
                sb = s + aumento;
                imposto = imposto * sb;
                sl = sb - imposto;

                //formatação para apenas 2 casas pós virgula
                sf = s.ToString("F2");
                aumentof = aumento.ToString("F2");
                sbf = sb.ToString("F2");
                slf = sl.ToString("F2");
                impostof = imposto.ToString("F2");

                //Resultado
                Home();
                Console.WriteLine($"\nO seu salário antigo era R${sf}.\nO seu aumento será de {aumentof}\nO seu novo salário bruto será de R${sbf}.\nO seu novo salário liquido será de R${slf}.\nO total de impostos será de R${impostof}\n\n\n\n");
                Console.WriteLine("######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                  Exercício 16                                  ###");
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
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 16                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                               Folha de pagamento                               ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
        }
    }
}
