namespace Exercise013
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            //create list
            List<Item> items = new List<Item>();

            // Ask for input

            while (true)
            {
                Console.WriteLine("Identifier? (empty will stop):");
                string identifier = Console.ReadLine();
                if (identifier == "")
                {
                    break;
                }
                Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();
                if (identifier == "")
                {
                    break;
                }
                //create object everytime in loop
                Item input = new Item(identifier, name);
                //check it item is already present in the list(based on identifier only)
                if (items.Contains(input))
                {
                    continue;
                }
                else
                {
                    //add object to list
                    items.Add(input);
                }


            }
            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}