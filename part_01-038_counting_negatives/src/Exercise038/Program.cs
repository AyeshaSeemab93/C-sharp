namespace Exercise038
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;
            int negativeNum = 0;

            while (true)
            {
                Console.WriteLine("Give a number:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
                else if (number < 0)
                {
                    negativeNum++;
                }
            }
            Console.WriteLine("Total amount of negative numbers: " + negativeNum);
        }
    }
}
