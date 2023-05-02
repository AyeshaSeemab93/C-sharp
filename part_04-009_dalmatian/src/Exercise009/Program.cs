namespace Exercise009
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Dalmatian spotty = new Dalmatian("Spot", 306);
            Console.WriteLine(spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur");
        }
    }
}