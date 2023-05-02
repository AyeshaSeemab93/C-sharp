namespace Exercise008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give numbers:");
            int input = Convert.ToInt32(Console.ReadLine());
            int target = -1;
            double count = 0;
            double sum = 0;
            double average = 0;
            int even = 0;
            int odd = 0;

            while (input != target)
            {

                sum += input;
                count++;
                average = sum / count;
                if (input % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                input = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Thx! Bye!\n" + "Sum: " + sum + "\nNumbers: " + count + "\nAverage: " + average);
            Console.WriteLine("Even: " + even + "\nOdd: " + odd);
        }
    }
}
