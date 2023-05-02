namespace Exercise003
{
    using System;
    // creating class
    class Book
    {
        // 1.creating attributes in class
        public string title;
        public string author;
        public int pages;

        //2.creating constructor(method) inside class
        public Book(string atitle, string aauthor, int apages)//5. creating parameters in constructors.To ease the lengthy step 4
        {
            title = atitle; //giving parameter's values to attributes
            author = aauthor;
            pages = apages;
            //apages to tell its argument 
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            //3. creating object in main
            Book book1 = new Book("Harry Potter", "Tom", 60)//6. giving values to step 5 or giving input or doing step 4 easily way

            { //4. giving values to attributes inside object(basic)
                /*          book1.title = "Harry Potter";
                            book1.author = "Tom";
                            book1.pages = 60;           */
            }
Book book2 = new Book("Quran", "Allah", 1000);

            Console.WriteLine(book1.title);



        }


    }
}