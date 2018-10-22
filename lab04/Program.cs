using System;
namespace lab04
{
    class Program
    {
        static void Main()
        {
            Console.Out.WriteLine("ВВОД A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Out.WriteLine("ВВОД B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Out.WriteLine("ВВОД C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                if (i % c == 0)
                    Console.Out.WriteLine(i);
            }
        }
    }
}