namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(array);
        }
        public static void PrintArrayInStars(int[] array)
        {
            foreach (int i in array)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

    }
}