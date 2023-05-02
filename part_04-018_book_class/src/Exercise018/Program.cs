namespace Exercise018
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());
                Console.Write("Publication year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Book book = new Book(name, pages, year);
                books.Add(book);
            }
            Console.WriteLine("");
            Console.Write("What information will be printed? ");
            string info = Console.ReadLine();

            foreach (Book output in books)
            {
                if (info == "everything")
                {
                    Console.WriteLine(output);
                }
                else if (info == "title")
                {
                    Console.WriteLine(output.title);
                }
                else
                {
                    break;
                }
            }



        }

    }
}