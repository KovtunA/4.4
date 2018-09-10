using System;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter А ");
            int a = getNumber();
            Console.WriteLine("Enter B ");
            int b = getNumber();
            Console.WriteLine("Enter C ");
            int c = getNumber();
   
            Console.WriteLine($"Your result {calculate(a, b, c)}");
        }

        public static int calculate(int a, int b, int c)
        {
            return Math.Max(a * b * c, a + b + c) + 3;
        }

        private static Int32 getNumber()
        {
            string userInput = Console.ReadLine();

            try { return Convert.ToInt32(userInput); }
            catch
            {
                Console.WriteLine("Invalid input, please try again");
                return getNumber();
            }
        }
    }
}
