namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your percent [0 - 100]:");
            int percentage = Convert.ToInt32(Console.ReadLine());

            if (percentage < 0)
            {
                Console.WriteLine("Impossible");
            }
            else if (percentage <= 49)
            {
                Console.WriteLine("Fail");
            }
            else if (percentage <= 59)
            {
                Console.WriteLine("Grade: 1");
            }
            else if (percentage <= 69)
            {
                Console.WriteLine("Grade: 2");
            }
            else if (percentage <= 79)
            {
                Console.WriteLine("Grade: 3");
            }
            else if (percentage <= 89)
            {
                Console.WriteLine("Grade: 4");
            }
            else if (percentage <= 100)
            {
                Console.WriteLine("Grade: 5");
            }
            else if (percentage > 100)
            {
                Console.WriteLine("Outstanding!");
            }

        }
    }
}
