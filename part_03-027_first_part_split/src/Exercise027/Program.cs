namespace Exercise027
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                string[] split = input.Split(" ");
                if (input == "")
                {
                    break;
                }
                Console.WriteLine(split[0]);
            }
        }
    }
}