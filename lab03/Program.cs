using System;
namespace lab03
{
    class Program
    {
        static void Main()
        {
            bool isRestart;
            do
            {
                Random rand = new Random();
                int N, M, summ = 0;
                int i, j;

                Console.Write("Введите кол-во строк [3-10]\nВВОД: ");
                N = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nВведите кол-во столбцов [3-10]\nВВОД: ");
                M = Convert.ToInt32(Console.ReadLine());

                int[,] matrix = new int[N, M];

                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                    {
                        matrix[i, j] = rand.Next(11) - 5;
                    }
                }

                Console.WriteLine("\nМатрица: ");
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < M; j++)
                    {
                        Console.Write(String.Format("[{0, 2}]", matrix[i, j]));
                        if (i == j)
                        {
                            if (j < M - 1)
                            {
                                summ = summ + matrix[i, j] + matrix[i, j + 1];
                            }
                            else if (j == M - 1)
                            {
                                summ += matrix[i, j];
                            }
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nСумма элементов\nСУММА: " + summ);
                char input = Convert.ToChar(Console.ReadLine());
                if (input == 'Y' || input == 'y')
                    isRestart = true;
                else
                    isRestart = false;
            } while (isRestart);
        }
    }
}