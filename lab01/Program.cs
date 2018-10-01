using System;
namespace lab01
{
    class Program
    {
        static void Main()
        {
            string someStr;
            Console.Write("Исхд. строка: ");
            someStr = Console.ReadLine();
            someStr = someStr.Replace(" ", string.Empty);
            Console.WriteLine("Форм. строка: " + someStr);
        }
    }
}