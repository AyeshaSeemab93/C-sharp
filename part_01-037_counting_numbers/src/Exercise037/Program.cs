namespace Exercise037
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            int count = 0;

            while (true)
            {
                Console.WriteLine("Give a number:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
                count = count + 1;
            }
            Console.WriteLine("Total amount of numbers: " + count);

        }
    }
}
