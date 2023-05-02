namespace Exercise008
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
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                list.Add(number);
            }
            Console.WriteLine("From where?");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where to?");
            int end = Convert.ToInt32(Console.ReadLine());

            /*for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= start && list[i] <= end)
                {
                    Console.WriteLine(list[i]);

                } */

            //Put all the values of list in variable (number) and use variable in place of list
            foreach (int number in list)
            {
                if (number >= start && number <= end)
                {
                    Console.WriteLine(number);
                }
            }

        }
    }

}


