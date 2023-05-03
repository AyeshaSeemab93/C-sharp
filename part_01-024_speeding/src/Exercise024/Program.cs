namespace Exercise024
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Your speed:");
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed > 120)
            {
                Console.WriteLine("Speeding!");
            }
        }
    }
}
