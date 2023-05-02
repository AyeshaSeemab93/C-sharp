namespace Exercise023
{
    using System;
    using System.IO;
    public class Program
    {

        public static void Main(string[] args)
        {
            {

                Console.WriteLine("Name of the file:");
                string file = Console.ReadLine();



                string names = File.ReadAllText(file);


                Console.WriteLine("");

                Console.WriteLine("Enter names, an empty line quits.");
                while (true)
                {
                    string name = Console.ReadLine();
                    if (name == "")
                    {
                        break;
                    }

                    if (names.Contains(name))
                    {
                        Console.WriteLine("The name is on the list.");
                    }
                    else
                    {
                        Console.WriteLine("The name is not on the list.");
                    }
                }
                Console.WriteLine("Thank you!");
            }
        }
    }
}