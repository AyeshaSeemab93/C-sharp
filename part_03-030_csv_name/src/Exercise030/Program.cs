namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            string nameofoldest = "";

            while (true)
            {

                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                string[] split = input.Split(",");
                //input is name,age    [0]=name [1]=age
                //age is given as string lets convert it to integers for calculation.
                int age = Convert.ToInt32(split[1]);
                {
                    if (age > oldest)
                    {
                        oldest = age;
                        nameofoldest = split[0]; //[0] bec names are given at 1st index value
                    }

                }

            }

            Console.WriteLine("Name of the oldest: " + nameofoldest);
        }

    }
}