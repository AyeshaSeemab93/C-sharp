namespace Exercise026
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
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i].Contains("av"))
                    {
                        Console.WriteLine(split[i]);
                    }
                }


            }
        }
    }
}