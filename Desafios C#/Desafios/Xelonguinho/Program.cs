using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                int quantidadeDeEsferasTotal = int.Parse(Console.ReadLine());
                int quantidadeFinalEsferas = 0;
                for (int j = 1; j <= quantidadeDeEsferasTotal; j++)
                {
                    int divisores = 0;
                    for (int k = 1; k <= j; k++)
                    {
                        if (j % k == 0)
                        {
                            divisores++;
                        }
                    }
                    if (divisores % 2 == 0)
                    {
                        quantidadeFinalEsferas++;
                    }
                }
                Console.WriteLine(quantidadeFinalEsferas);
            }
        }
    }
}