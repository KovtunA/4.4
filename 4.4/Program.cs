using System;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter А ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine($"Your result {Max(a, b, c)}");
        }

        public static int Max(int a, int b, int c)
        {
            return Math.Max(a * b * c, a + b + c) + 3;
        }

    }
}
