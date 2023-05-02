namespace Exercise021
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] line = File.ReadAllLines("data.txt");
            foreach (string lines in line)
            {
                Console.WriteLine(lines);
            }

        }
    }
}