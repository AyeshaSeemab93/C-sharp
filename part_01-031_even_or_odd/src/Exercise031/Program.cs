namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            string number = Console.ReadLine();
            int integer = Convert.ToInt32(number);
            if (integer % 2 == 0)
            {
                Console.WriteLine("It is even.");
            }
            else
            {
                Console.WriteLine("It is odd.");
            }
        }
    }
}
