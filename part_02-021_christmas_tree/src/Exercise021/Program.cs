namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(String[] args)
        {
            PrintStars(5);
            PrintSpaces(5);
            Console.WriteLine("\n \n");
            PrintRightTriangle(4);
            Console.WriteLine("\n \n");
            ChristmasTree(10);
        }
        public static void PrintStars(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        public static void PrintSpaces(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(" ");
            }
        }
        public static void PrintRightTriangle(int size)
        {


            for (int x = 1; x <= size; x++) // first loop for  entering row1,2,3,4
            {
                PrintSpaces(size - x);
                /*for (y = 1; y <= size - x; y++) //2nd loop for spacing..keep running until sixe-x(5-1 =4)4 times then go further
                {
                    Console.Write(" ");
                }*/
                PrintStars(x);
                /*for (z = 1; z <= x; z++) //3rd loop for stars
                {
                    Console.Write("*");
                }

                Console.WriteLine(); */
            }
        }
        public static void ChristmasTree(int height)
        {
            int star = 1;
            int spc = height - 1;

            for (int i = 1; i < height; i++) // loop for rows
            {
                /*  PrintSpaces(height - 1);*/
                for (int r = 1; r <= spc; r++)
                {
                    Console.Write(" ");
                }
                /* PrintStars(i * 2 - 1);*/
                for (int s = 1; s <= star; s++)
                {
                    Console.Write("*");
                }
                spc--; // to reduce space on left side otherwise just triangle
                star = star + 2; // bec in tree in each row 2 stars are increasing.

                Console.WriteLine();
            }
            int h = 2;
            int width = 3;
            int gap = height - 2;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 0; j < gap; j++)
                { Console.Write(" "); }
                for (int k = 1; k <= width; k++)
                { Console.Write("*"); }

                Console.WriteLine();
            }

            System.Diagnostics.Debug.WriteLine("Ayesha Testing");

        }
    }
}