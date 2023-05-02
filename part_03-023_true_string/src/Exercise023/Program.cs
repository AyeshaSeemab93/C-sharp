namespace Exercise023
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string input = Console.ReadLine();
            string answer = "true";
            if (input == answer)
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}
