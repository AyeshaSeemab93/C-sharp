namespace Exercise018
{
    using System;
    public class Book
    {
        public string title { get; set; }
        public int pages;
        public int publicationYear;

        public Book(string title, int pages, int year)
        {
            this.title = title;
            this.pages = pages;
            this.publicationYear = year;
        }

        public override string ToString()
        {
            return this.title + ", " + this.pages + " pages, " + this.publicationYear;
        }


    }
}