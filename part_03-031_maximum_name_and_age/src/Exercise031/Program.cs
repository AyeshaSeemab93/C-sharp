namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            string longestname = "";
            int highestAge = 0;
            while (true)
            {

                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] split = input.Split(",");

                for (int i = 0; i < split.Length; i++)
                { // if statement for longest name
                  //compare lengths of strings
                    if (split[i].Length > longestname.Length)
                    {
                        longestname = split[i];
                    }
                    // highest age
                    // input years are string.Convert to int for calculation.
                    int age = 2023 - Convert.ToInt32(split[1]);

                    if (highestAge < age)
                    {
                        highestAge = age;
                    }

                }
            }
            Console.WriteLine("Longest name: " + longestname);
            Console.WriteLine("Highest age: " + highestAge);


        }
    }
}