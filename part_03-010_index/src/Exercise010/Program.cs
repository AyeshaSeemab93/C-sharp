namespace Exercise010
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
            }
            Console.WriteLine("Search for?");
            int searchNo = Convert.ToInt32(Console.ReadLine());
            // finding index no so make its variable.
            int index = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == searchNo)
                {
                    index = i;// store index when number match
                    Console.WriteLine(searchNo + " is at index " + index);
                }


            }
            {

            }
        }
    }
}
