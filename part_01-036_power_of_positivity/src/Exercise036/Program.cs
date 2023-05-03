namespace Exercise036
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            int power;
            while (true)
            {
                Console.WriteLine("Give a number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else if (number > 0)
                {
                    power = number * number;
                    Console.WriteLine(power);
                }
                else if (number < 0)
                {
                    Console.WriteLine("That is negative");
                }
            }
        }
    }
}
