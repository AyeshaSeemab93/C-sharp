namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number!");
            string number = Console.ReadLine();
            int intValue = Convert.ToInt32(number);
            Console.WriteLine("You gave " + intValue);
        }
    }
}
