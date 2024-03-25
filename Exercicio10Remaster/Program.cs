namespace Exercicio10Remaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Cabecalho();

                //Dados
                int tdn = LerInt("\nInforme a quantia de notas que serão somadas: ");
                double[] nota = new double[tdn];
                double[] peso = new double[tdn];

                Cabecalho();

                int aux = 0, aux2;
                Console.WriteLine("\nValor das notas!");
                while (aux < tdn)
                {
                    aux2 = aux + 1;
                    nota[aux] = LerDouble($"\nInforme o valor da {aux2}ª nota: ");
                    aux++;
                }

                Cabecalho();
                Console.WriteLine("\nValor dos pesos!");
                aux = 0;
                while (aux < tdn)
                {
                    aux2 = aux + 1;
                    peso[aux] = LerDouble($"\nInforme o valor do {aux2}º peso: ");
                    aux++;
                }


                //Equação
                double total = Equacao(tdn, nota, peso);



                //Resultado
                Cabecalho();
                Console.WriteLine($"\nA média ponderada das notas é: {total}.");

                op = Rexit();
                
            }
            Exit();
        }

        

        private static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 10                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                            Média ponderada das notas                           ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
        }
        static int LerInt(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = int.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }

                Console.Write("\nPor favor digite um numero.\n\nPrecione qualquer tecla para continuar.");
                Console.ReadLine();
                Cabecalho();
            }
        }
        static double LerDouble(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = double.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }

                Console.Write("\nPor favor digite um numero.\n\nPrecione qualquer tecla para continuar.");
                Console.ReadLine();
                Cabecalho();
            }
        }
        private static double Equacao(int tdn, double[] nota, double[] peso)
        {
            double notap = 0, tpeso = 0;
            for (int cont = 0; cont < tdn; cont++)
            {
                notap += nota[cont] * peso[cont];
                tpeso += peso[cont];
            }
            double total = notap / tpeso;
            return total;
        }
        static int Rexit()
        {
            int op;
            while (true)
            {
                op = LerInt("\nEscolha sua opção. \n1. Calcular outro valor \n2. Sair \nDigite sua opção: ");

                if (op != 1 && op != 2)
                {
                    Console.WriteLine("\nOpção inválida, escolha uma opção válida entre 1 e 2. \n\nPrecione qualquer tecla para continuar.\n");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
            return op;
        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###              Academia do programador 2024 - Lista de Exercícios 1              ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                  Exercício 10                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
