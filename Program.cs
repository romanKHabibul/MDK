using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Введите значение n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение m: ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] masA = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    masA[i, j] = random.Next(-10, 10);
                }
            }

            Console.WriteLine("\r\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(masA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int k = 0, sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += masA[j, i];
                }

                for (int j = 0; j < n; j++)
                {
                    if (masA[j, i] > (sum - masA[j, i]))
                        k++;
                }
            }

            Console.Write("\r\nКоличество особых элементов - {0}", k);

        }
    }
}
