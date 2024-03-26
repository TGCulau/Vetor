using Microsoft.VisualBasic;

namespace VetorRefatorado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opm = 0;
            while (opm != 9)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                
                int tamanhodovetor;
                while (true)
                {
                    Cabecalho();
                    tamanhodovetor = LerInt("\nDigite o tamanho do vetor: ");
                    if (tamanhodovetor <= 0)
                    {
                        Console.Write("\nO numero precisa ser maior que zero, por favor, tente novamente.\n\nPrecione qualquer tecla para continuar.");
                        Console.ReadLine();
                        continue;
                    }
                    break;
                }

                
                int[] num = new int[tamanhodovetor];
                Cabecalho();
                Console.Write($"\nDigite os numeros inteiros do vetor\n\n");
                int aux = 0;
                for (int i = 0; i < tamanhodovetor; i++)
                {
                    num[i] = LerInt($"Digite o valor do {++aux}º numero: ");
                }

                
                while (opm != 9 && opm != 8)
                {
                    Cabecalho();
                    opm = Menu();

                    switch (opm)
                    {
                        case 1:
                            Cabecalho();
                            MaiorNumero(num, tamanhodovetor);
                            break;

                        case 2:
                            Cabecalho();
                            MenorNumero(num, tamanhodovetor);
                            break;

                        case 3:
                            Cabecalho();
                            Media(num, tamanhodovetor);
                            break;

                        case 4:
                            Cabecalho();
                            TresMaiores(num, tamanhodovetor);
                            break;

                        case 5:
                            Cabecalho();
                            NumerosNegativos(num, tamanhodovetor);
                            break;

                        case 6:
                            Cabecalho();
                            Sequencia(num, tamanhodovetor);
                            break;

                        case 7:
                            Cabecalho();
                            tamanhodovetor = Apagar(tamanhodovetor, num);
                            break;

                        case 8:
                            Exit();
                            break;
                    }
                }
            }
        }

        static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                          Academia do programador 2024                          ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                   Atividade 4                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                        Converter Fahrenheit em Celsius                         ###");
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
        static int Menu()
        {
            int opm;
            while (true)
            {
                Cabecalho();
                opm = LerInt("\nEscolha sua opção.\n\n1. Encontrar o Maior Valor da sequência\n2. Encontrar o Menor Valor da sequência\n3. Encontrar o Valor Médio da sequência\n4. Encontrar os 3 maiores valores da sequência\n5. Encontrar os valores negativos da sequência\n6. Mostrar na Tela os valores da sequência\n7. Remover um item da sequência\n8. Inserir novos dados\n9. Sair\n\nDigite sua opção: ");
                if (opm != 1 && opm != 2 && opm != 3 && opm != 4 && opm != 5 && opm != 6 && opm != 7 && opm != 8 && opm != 9)
                {
                    Console.Write("\nPor favor escolha uma opção valida do menu.\n\nPrecione qualquer tecla para continuar.");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
            return opm;
        }
        static void MaiorNumero(int[] num, int tamanhodovetor)
        {
            int maiornum = num[0];
            for (int i = 0; i < tamanhodovetor; i++)
            {

                if (num[i] > maiornum)
                {
                    maiornum = num[i];
                }
            }
            Console.WriteLine($"\nO maior numero é {maiornum}.\n\n\nPrecione qualquer tecla para retornar ao menu inicial.");
            Console.ReadLine();
        }
        static void MenorNumero(int[] num, int tamanhodovetor)
        {
            int menornum = num[0];
            for (int i = 0; i < tamanhodovetor; i++)
            {

                if (num[i] < menornum)
                {
                    menornum = num[i];
                }
            }
            Console.WriteLine($"\nO menor numero é {menornum}.\n\n\nPrecione qualquer tecla para retornar ao menu inicial.");
            Console.ReadLine();
        }
        static void Media(int[] num, int tamanhodovetor)
        {
            decimal media = 0;
            for (int i = 0; i < tamanhodovetor; i++)
            {
                media += num[i];
            }
            media /= tamanhodovetor;
            Console.WriteLine($"\nA media é {media}.\n\n\nPrecione qualquer tecla para retornar ao menu inicial.");
            Console.ReadLine();
        }
        static void TresMaiores(int[] num, int tamanhodovetor)
        {
            int maiornum = num[0];
            for (int i = 0; i < tamanhodovetor; i++)
            {

                if (num[i] > maiornum)
                {
                    maiornum = num[i];
                }
            }

            int aux = maiornum;
            int cont = 0;
            Console.Write($"\nOs tres maiores numeros são: ");
            while (true)
            {
                for (int i = 0; i < tamanhodovetor; i++)
                {
                    if (num[i] == aux)
                    {
                        //maiornum = num[i];
                        Console.Write($"{num[i]}  ");
                        aux--;
                        cont++;
                    }
                }
                if (cont == 3)
                {
                    break;
                }
            }
            Console.Write("\n\n\nPrecione qualquer tecla para retornar ao menu inicial.");
            Console.ReadLine();
        }
        static void NumerosNegativos(int[] num, int tamanhodovetor)
        {
            Console.Write($"\nOs numeros negativos são: ");
            for (int i = 0; i < tamanhodovetor; i++)
            {
                if (num[i] < 0)
                {
                    Console.Write($"{num[i]}  ");
                }
            }
            Console.Write("\n\n\nPrecione qualquer tecla para retornar ao menu inicial.");
            Console.ReadLine();
        }
        static void Sequencia(int[] num, int tamanhodovetor)
        {
            Console.Write($"\nOs numeros desta sequencia são: ");
            for (int i = 0; i < tamanhodovetor; i++)
            {
                Console.Write($"{num[i]}  ");
            }
            Console.Write("\n\n\nPrecione qualquer tecla para retornar ao menu inicial.");
            Console.ReadLine();
        }
        static int Apagar(int tamanhodovetor, int[] num)
        {
            //Imprimindo os numeros da sequencia novamente
            Console.Write($"\nOs numeros desta sequencia são: ");
            for (int i = 0; i < tamanhodovetor; i++)
            {
                Console.Write($"{num[i]}  ");
            }

            Console.Write($"\nQual numero deseja apagar? ");
            int aux2 = Convert.ToInt32(Console.ReadLine());
            int aux3;
            for (int i = 0; i < tamanhodovetor; i++)
            {
                if (num[i] == aux2)
                {
                    aux3 = i;
                    int aux4 = i + 1;
                    for (int j = aux4; j < tamanhodovetor; j++)
                    {
                        num[aux3] = num[j];
                        aux3++;
                    }
                    i--;
                }
            }
            tamanhodovetor--;

            //Imprimindo os numeros da sequencia novamente
            Console.Write($"\nOs numeros desta sequencia agora são: ");
            for (int i = 0; i < tamanhodovetor; i++)
            {
                Console.Write($"{num[i]}  ");
            }
            Console.Write("\n\n\nPrecione qualquer tecla para retornar ao menu inicial.");
            Console.ReadLine();
            return tamanhodovetor;
        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                          Academia do programador 2024                          ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                   Atividade 4                                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                    Obrigado                                    ###");
            Console.WriteLine("###                  Até mais. Precione qualquer tecla para sair.                  ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
