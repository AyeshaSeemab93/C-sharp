namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int second = Convert.ToInt32(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine("The larger number is " + first + "!");
            }
            else if (first < second)
            {
                Console.WriteLine("The larger number is " + second + "!");
            }
            if (first == second)
            {
                Console.WriteLine("They are equal!");
            }
        }
    }
}
