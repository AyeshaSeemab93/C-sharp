namespace Exercise011
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            int input = Convert.ToInt32(Console.ReadLine());
            PrintUntilNumber(input);
        }
        public static void PrintUntilNumber(int number)
        {
            int i = 1;
            while (i <= number)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
}
