namespace Exercise040
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            int totalNum = 0;

            while (true)
            {
                Console.WriteLine("Give a number:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
                sum = sum + number;
                totalNum++;
            }
            Console.WriteLine("Total sum of numbers: " + sum + "\n" + "Total amount of numbers: " + totalNum);
        }
    }
}
