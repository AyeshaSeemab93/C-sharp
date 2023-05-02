namespace Exercise004
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int first = Convert.ToInt32(Console.ReadLine());

            int second = Convert.ToInt32(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine(first + " is greater than " + second + ".");

            }
            else if (first < second)
            {
                Console.WriteLine(first + " is less than " + second + ".");
            }
            else
            {
                Console.WriteLine(first + " is equal to " + second + ".");
            }


        }
    }
}
