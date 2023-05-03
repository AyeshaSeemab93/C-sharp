namespace Exercise017
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;
            System.Console.WriteLine("Give the first number!");
            num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Give the second number!");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum is " + (num1 + num2));

        }
    }
}