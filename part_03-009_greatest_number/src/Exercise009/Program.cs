namespace Exercise009
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            } //find number so make its variable
            int largest = list[0];// suppose 1st number as greatest to compare
                                  // for loop for moving in the list
            for (int i = 0; i < list.Count; i++)
            {
                if (largest < list[i])
                {
                    largest = list[i]; //store number
                }
            }
            Console.WriteLine("The greatest number: " + largest);

        }
    }
}


