namespace Exercise024
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string username1 = "alex";
            string password1 = "sunshine";
            string username2 = "emma";
            string password2 = "haskell";
            Console.WriteLine("Enter username:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            bool success = false;
            if (name == username1 && password == password1)
            {
                Console.WriteLine("You have successfully logged in!");
                success = true;
            }
            if (name == username2 && password == password2)
            {
                Console.WriteLine("You have successfully logged in!");
                success = true;
            }
            else if (success != true)
            {
                Console.WriteLine("Incorrect username or password!");
            }

        }
    }
}