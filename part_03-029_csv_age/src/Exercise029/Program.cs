namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] split = input.Split(",");

                if (Convert.ToInt32(split[1]) > oldest)
                {
                    oldest = Convert.ToInt32(split[1]);
                }

            }
            Console.WriteLine("Age of the oldest: " + oldest);
        }
    }
}