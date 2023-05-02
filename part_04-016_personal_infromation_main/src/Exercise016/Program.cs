namespace Exercise016
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        { //1 create list
            List<PersonalInformation> list = new List<PersonalInformation>();

            // 2. input
            while (true)
            {
                Console.WriteLine("First name:");
                string first = Console.ReadLine();
                if (first == "")
                {
                    break;
                }
                Console.WriteLine("Last name:");
                string last = Console.ReadLine();
                Console.WriteLine("Identification number:");
                string identificationNo = Console.ReadLine();

                // 3. create object from input
                PersonalInformation data = new PersonalInformation(first, last, identificationNo);
                // 4. add object to list
                list.Add(data);
            }





            Console.WriteLine();

            foreach (PersonalInformation item in list)
            {
                // getting value of specific variable from list? list(name).variable(name)
                System.Console.WriteLine(item.firstName + " " + item.lastName);
            }

        }
    }
}