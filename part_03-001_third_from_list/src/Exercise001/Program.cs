namespace Exercise001
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("Please add names: ");
                string input = Console.ReadLine();
                list.Add(input);
                if (input == "")
                {
                    break;
                }
            }
            Console.WriteLine(list[2]);
        }
    }
}
