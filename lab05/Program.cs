using System;
namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M, summ;
            Console.Write("Введите кол-во строк\nВВОД: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите кол-во столбцов\nВВОД: ");
            M = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[N, M];
            fillMatrix(N, M, ref matrix);
            Console.Write("\nВведите номер строки [1-" + N + "]\nВВОД: ");
            int rowNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            summ = sumCount(M, matrix, rowNumber);
            printMatrix(N, M, matrix);
            Console.WriteLine("\nСумма элементов: " + summ);
        }
        private static void fillMatrix(int N, int M, ref int[,] matrix)
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rand.Next(10);
                }
            }
        }
        private static int sumCount(int M, int[,] matrix, int rowNumber)
        {
            int summ = 0;
            for (int i = 0; i < M; i++)
            {
                summ += matrix[rowNumber, i];
            }

            return summ;
        }
        private static void printMatrix(int N, int M, int[,] matrix)
        {
            Console.WriteLine("\nМатрица: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(String.Format("[{0, 1}]", matrix[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}