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
            someStr = compress(someStr);
            Console.WriteLine("Форм. строка: " + someStr);
        }
        static string compress(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace(" ", string.Empty);
            }
            return str;
        }
    }
}