namespace Exercise015
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            string line = Console.ReadLine();

            Console.WriteLine("Give an integer:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give a double:");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give a boolean:");
            Boolean truth = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Your string: " + line);
            Console.WriteLine("Your integer: " + num);
            Console.WriteLine("Your double: " + value);
            Console.WriteLine("Your boolean: " + truth);

        }
    }
}
