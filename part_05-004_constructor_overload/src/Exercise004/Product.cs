namespace Exercise004
{
    public class Product
    {
        // DO NOT TOUCH THESE VARIABLES
        private string name;
        private string location;
        private int weight;

        public Product(string name) : this(name, "shelf")
        { }

        public Product(string name, string location) : this(name, 1)
        {

            this.location = location;

        }

        public Product(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
            this.location = "warehouse";
        }



        // DO NOT TOUCH THIS
        public override string ToString()
        {
            return $"{this.name} ({this.weight} kg) can be found from the {this.location}.";
        }
    }
}
