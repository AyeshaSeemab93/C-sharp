namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)

        {
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            Console.WriteLine();
            PrintSquare(4);
            Console.WriteLine();
            PrintRectangle(17, 3);
            Console.WriteLine();
            PrintTriangle(4);

        }
        public static void PrintStars(int number)
        {
            for (int i = 1; i <= number; i++)//how many no of stars
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
        public static void PrintSquare(int size)
        {
            for (int i = 1; i <= size; i++) //1st for loop for no of rows
            {
                PrintStars(size); // for printing stars+ next line only
            }
        }
        public static void PrintRectangle(int width, int height)
        {
            for (int i = 1; i <= height; i++)

            {
                PrintStars(width);
            }
        }
        public static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintStars(i);

            }

        }





    }

}








