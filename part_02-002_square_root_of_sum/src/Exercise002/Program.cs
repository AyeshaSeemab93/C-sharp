namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int sum = first + second;
            double squareRoot = Math.Sqrt(sum);
            Console.WriteLine(squareRoot);
        }
    }
}
