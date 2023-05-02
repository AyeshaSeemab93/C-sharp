namespace Exercise028
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] split = input.Split(" ");
                Console.WriteLine(split[split.Length - 1]);
            }

        }

    }
}