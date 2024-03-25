using System.Runtime.Intrinsics.X86;

namespace Exercicio2Remaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                //Home
                Cabecalho();

                //Body
                decimal temp = LerDecimal("\nDigite a temperatura em Fahrenheit: ");
                decimal c = Equacao(temp);
                Console.WriteLine($"\nA temperatura em Celsius é {c}ºC.\n\nPrecione qualquer tecla para continuar.");
                Console.ReadLine();
                //RexitLerDecimal(";
                decimal op = Rexit();
                if( op == 1 )
                {
                    continue;
                }
                //Saida
                Exit();
                break;

            }
        }
        private static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                   Exercício 2                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                        Converter Fahrenheit em Celsius                         ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
        }
        static decimal LerDecimal(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = decimal.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }

                Console.Write("\nPor favor digite um numero.\n\nPrecione qualquer tecla para continuar.");
                Console.ReadLine();
                Cabecalho();
            }
        }
        static decimal Equacao(decimal temp)
        {
            decimal aux = (temp - 32) * 0.5555555555555556m;
            aux = Math.Round(aux, 2);
            return aux;
        }
        static decimal Rexit() //Rexit = Restart or Exit
        {
            decimal opm;
            while (true)
            {
                Cabecalho();
                opm = LerDecimal("\nEscolha sua opção.\n\n1. Calcular outra temperatura\n2. Sair\n\nDigite sua opção: ");
                if (opm != 1 && opm != 2)
                {
                    Console.Write("\nPor favor escolha uma opção valida do menu.\n\nPrecione qualquer tecla para continuar.");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
            return opm;
        }
        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                   Exercício 2                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
