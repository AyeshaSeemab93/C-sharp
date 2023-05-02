namespace Exercise002
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int index = 0;
            while (index < 4)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }

                list.Add(input);
                index++;
            }
            int sum = list[1] + list[2];
            Console.WriteLine(sum);
        }
    }
}
