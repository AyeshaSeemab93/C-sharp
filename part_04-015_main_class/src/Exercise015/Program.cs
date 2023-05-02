namespace Exercise015
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {

            //1. create list(outside loop)
            List<Item> items = new List<Item>();
            // 2. take input(multiple so in loop)
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                //3. make object (from input)
                Item names = new Item(name);
                // 4. add object to list
                items.Add(names);
                // objects and addition to list inside loop bec many inputs are added
            }
            Console.WriteLine(); // asked in output
                                 // print list (output)
                                 //loop bec list has many elements

            foreach (Item output in items)
            { Console.WriteLine(output); }



        }
    }
}