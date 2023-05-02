namespace Exercise016
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            strings.Add("First");
            strings.Add("Secind");
            strings.Add("Third");


            RemoveLast(strings);
            strings.ForEach(Console.WriteLine);

        }
        public static void RemoveLast(List<string> strings)
        {
            int i = strings.Count - 1;
            strings.RemoveAt(i);
            return;
        }
    }
}
