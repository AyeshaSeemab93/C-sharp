namespace Exercise010
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many times?");
            int input = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < input)
            {
                PrintPhrase();
                i++;
            }

        }
        public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method");
        }
    }

}
