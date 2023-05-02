namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {


            System.Console.WriteLine("Give the first number!");
            int first = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Give the second number!");
            int second = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(first + " * " + second + " = " + (first * second));
        }
    }
}
