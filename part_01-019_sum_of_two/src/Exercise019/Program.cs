namespace Exercise019
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
            int sum = num1 + num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
        }
    }
}
