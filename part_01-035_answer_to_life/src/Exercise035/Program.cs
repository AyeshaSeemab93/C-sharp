namespace Exercise035
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            string question = "Give a number:";
            while (true)
            {
                Console.WriteLine(question);
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 42)
                {
                    break;
                }
            }
        }
    }
}
