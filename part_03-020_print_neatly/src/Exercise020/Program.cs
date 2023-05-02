namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 4, 2 };

            PrintNeatly(array);
        }

        public static void PrintNeatly(int[] array)
        {


            /*My correct method:
            for (int i = 0; i < array.Length; i++)
           {  

               Console.Write(array[i]);
               for (int j = 0; j < array.Length - 1; j++)
               {
                   if (j == i)
                   {
                       Console.Write(", ");

                   }
               }
           }

           Console.WriteLine(); */
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ", "); //print all the list except last number
            }

            Console.WriteLine(array[array.Length - 1]); // print last number array length -1 give last index position, then it print number present on last index position

        }
    }
}
