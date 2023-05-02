namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("");
            int input = Convert.ToInt32(Console.ReadLine());
            PrintFromNumberToOne(input);
        }
        public static void PrintFromNumberToOne(int number)
        {
            int i = number;
            int j = 1;
            while (i >= j)
            {
                Console.WriteLine(i);
                i--;
            }

        }
    }
}
