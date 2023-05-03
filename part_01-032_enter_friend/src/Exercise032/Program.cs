namespace Exercise032
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Speak, friend, and enter!");
            string response = Console.ReadLine();

            if (response == "Mellon")
            {
                Console.WriteLine("Welcome, friend");
            }
            else
            {
                Console.WriteLine("They've got a cave troll!");

            }

        }
    }
}
