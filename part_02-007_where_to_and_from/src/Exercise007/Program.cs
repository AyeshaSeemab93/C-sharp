namespace Exercise007
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Where to?");
            int upperLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where from?");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            if (upperLimit > lowerLimit)
            {
                for (int i = lowerLimit; i <= upperLimit; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
