using System;
namespace lab02
{
    class Program
    {
        static void Main()
        {
            bool isRepeat;
            do
            {
                int[] row = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29 };
                Console.WriteLine("Введите число элементов: ");
                int numb = Convert.ToInt32(Console.ReadLine()), summ = 0;
                for (int i = 0; i < numb; i++)
                {
                    summ += row[i];
                }
                Console.WriteLine("Сумма элементов ряда: " + summ);
                Console.WriteLine("Повторить?(Y/N)");
                char input = Convert.ToChar(Console.ReadLine());
                if (input == 'Y' || input == 'y')
                    isRepeat = true;
                else
                    isRepeat = false;
            } while ( isRepeat );
        }
    }
}