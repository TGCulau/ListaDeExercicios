namespace Exercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Variáveis
                int cont, cont1 = 1, cont2 = 2, cont3 = 3, cont4 = 4, cont5 = 5, cont6 = 1, aux, aux2, aux3, aux4, aux5;

                //Home
                Console.Clear();
                Console.WriteLine("########################################################################################################################");
                Console.WriteLine("###                                                                                                                  ###");
                Console.WriteLine("###                               Academia do programador 2024 - Lista de Exercícios 1                               ###");
                Console.WriteLine("###                                                                                                                  ###");
                Console.WriteLine("###                                                   Exercício 28                                                   ###");
                Console.WriteLine("###                                                                                                                  ###");
                Console.WriteLine("###                                                     Taboada                                                      ###");
                Console.WriteLine("###                                                                                                                  ###");

                //Resultado
                for (cont = 0; cont < 10; cont++)
                {

                    aux = cont1 * cont6;
                    aux2 = cont2 * cont6;
                    aux3 = cont3 * cont6;
                    aux4 = cont4 * cont6;
                    aux5 = cont5 * cont6;
                    Console.WriteLine($"###\t     {cont1} x {cont6} = {aux}   \t{cont2} x {cont6} = {aux2}   \t{cont3} x {cont6} = {aux3}   \t{cont4} x {cont6} = {aux4}   \t{cont5} x {cont6} = {aux5}\t                     ###");
                    cont6++;
                }
                Console.WriteLine("###                                                                                                                  ###");

                cont1 = 6;
                cont2 = 7;
                cont3 = 8;
                cont4 = 9;
                cont5 = 10;
                cont6 = 1;

                for (cont = 0; cont < 10; cont++)
                {
                    aux = cont1 * cont6;
                    aux2 = cont2 * cont6;
                    aux3 = cont3 * cont6;
                    aux4 = cont4 * cont6;
                    aux5 = cont5 * cont6;
                    Console.WriteLine($"###\t     {cont1} x {cont6} = {aux}   \t{cont2} x {cont6} = {aux2}   \t{cont3} x {cont6} = {aux3}   \t{cont4} x {cont6} = {aux4}   \t{cont5} x {cont6} = {aux5}\t                     ###");
                    cont6++;
                }
                
                Console.WriteLine("###                                                                                                                  ###");
                Console.WriteLine("###                                                     Obrigado                                                     ###");
                Console.WriteLine("###                                   Até mais. Precione qualquer tecla para sair.                                   ###");
                Console.WriteLine("###                                                                                                                  ###");
                Console.WriteLine("########################################################################################################################");
                Console.ReadLine();
            }
        }
    }
}
