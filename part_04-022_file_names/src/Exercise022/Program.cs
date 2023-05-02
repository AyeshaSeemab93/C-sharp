namespace Exercise022
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which file should have its contents printed?");
            string input = Console.ReadLine();
            string[] line = File.ReadAllLines(input);
            foreach (string lines in line)
            {
                Console.WriteLine(lines);
            }

        }
    }
}