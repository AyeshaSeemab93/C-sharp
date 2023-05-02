namespace Exercise012
{
    public class Book
    {

        private string name;
        private int publicationYear;

        public Book(string name, int publicationYear)
        {
            this.name = name;
            this.publicationYear = publicationYear;
        }



        public override bool Equals(object compared)
        {
            if (this == compared)
            {
                return true;
            }
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }

            Book comparedBook = (Book)compared;

            if (this.name == comparedBook.name &&
             this.publicationYear == comparedBook.publicationYear)

            {
                return true;
            }


            return false;
        }
        // to clear terminal error:    warning CS0659: 'Book' overrides Object.Equals(object o) but does not override Object.GetHashCode()
        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }

    }
}

