namespace Exercise022
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give the second number!");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give the third number!");
            double third = Convert.ToDouble(Console.ReadLine());

            double average = (first + second + third) / 3.0;

            Console.WriteLine("The average is " + average);
        }
    }
}
