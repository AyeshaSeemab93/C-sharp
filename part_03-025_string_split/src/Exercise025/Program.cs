namespace Exercise025
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                string strings = Console.ReadLine();
                string[] portions = strings.Split(" ");

                if (strings == "")
                {
                    break;
                }

                int i = 0;
                while (i < portions.Length)
                {


                    Console.WriteLine(portions[i]);
                    i++;

                }

            }


        }
    }
}
