namespace Exercise011
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
                if (input == 9999)
                {
                    break;
                }
                list.Add(input);
            }
            int smallest = list[0];
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                }
            }
            Console.WriteLine("Smallest number: " + smallest);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == smallest)
                {
                    index = i;
                    Console.WriteLine("Found at index: " + index);
                }

            }



        }
    }
}
