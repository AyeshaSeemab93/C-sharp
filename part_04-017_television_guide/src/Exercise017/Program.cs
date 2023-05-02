namespace Exercise017
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            //create list
            List<TelevisionProgram> list = new List<TelevisionProgram>();
            //input
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                Console.Write("Duration: ");
                int duration = Convert.ToInt32(Console.ReadLine());
                // create object
                TelevisionProgram program = new TelevisionProgram(name, duration);
                // adding objects to list
                list.Add(program);

            }
            Console.WriteLine("");
            Console.Write("Program's maximum duration? ");
            int maxDuration = Convert.ToInt32(Console.ReadLine());

            foreach (TelevisionProgram output in list)
            {
                //every(name+duration) is stored in 1 object(program). 5 objects are stored in list. we check each list's element's duration against maxDuration.

                if (output.duration <= maxDuration)
                {
                    Console.WriteLine(output);
                }
            }
        }
    }
}