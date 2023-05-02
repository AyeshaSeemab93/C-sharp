namespace Exercise003
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int answer = 0;
            int integer = Convert.ToInt32(Console.ReadLine());
            if (integer < 0)
            {
                answer = integer * (-1);
                Console.WriteLine(answer);
            }
            else
                Console.WriteLine(integer);
        }
    }
}
