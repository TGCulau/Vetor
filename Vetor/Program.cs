namespace VetorTripaseca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            int tamanhodovetor = 10;
            int[] num = new int[tamanhodovetor];

            num[0] = -5;
            num[1] = 3;
            num[2] = 4;
            num[3] = 5;
            num[4] = 9;
            num[5] = 6;
            num[6] = 10;
            num[7] = -2;
            num[8] = 11;
            num[9] = 1;

            //Maior valor da sequencia
            int maiornum = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                
                if (num[i] > maiornum)
                {
                    maiornum = num[i];
                }
            }
            Console.WriteLine($"O maior numero é {maiornum}.");
            Console.ReadLine();

            //Menor valor da sequencia
            int menornum = num[0];
            for (int i = 0; i < num.Length; i++)
            {

                if (num[i] < menornum)
                {
                    menornum = num[i];
                }
            }
            Console.WriteLine($"O menor numero é {menornum}.");
            Console.ReadLine();

            //Media dos valores
            decimal media = 0;
            for (int i = 0; i < num.Length; i++)
            {
                media += num[i];
            }
            media /= 10;
            Console.WriteLine($"A media é {media}.");
            Console.ReadLine();

            //3 maiores
            int aux = maiornum, cont = 0;
            Console.Write($"Os tres maiores numeros são: ");
            while (true)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] == aux)
                    {
                        maiornum = num[i];
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
            Console.ReadLine();

            //Numeros negativos
            //int aux = maiornum, cont = 0;
            Console.Write($"\nOs numeros negativos são: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    Console.Write($"{num[i]}  ");
                }
            }
            Console.ReadLine();

            //Imprimindo os numeros da sequencia
            Console.Write($"\nOs numeros desta sequencia são: ");
            for (int i = 0; i < num.Length; i++)
            {
                    Console.Write($"{num[i]}  ");
            }
            Console.ReadLine();

            //Apagar numero da sequencia
            Console.Write($"\nQual numero deseja apagar? ");
            int aux2 = Convert.ToInt32(Console.ReadLine());
            int aux3;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == aux2)
                {
                    aux3 = i;
                    int aux4 = i + 1;
                    for (int j = aux4; j < num.Length; j++)
                    {
                        num[aux3] = num[j];
                        aux3++;
                    }
                    i--;
                    tamanhodovetor = tamanhodovetor - 1;
                }
            }
            
            //Imprimindo os numeros da sequencia novamente
            Console.Write($"\nOs numeros desta sequencia são: ");
            for (int i = 0; i < tamanhodovetor; i++)
            {
                Console.Write($"{num[i]}  ");
            }
            Console.ReadLine();
        }
    }
}