namespace Exercise001
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int integer = Convert.ToInt32(input);
            int secondPower = integer * integer;
            Console.WriteLine(secondPower);
        }
    }
}
