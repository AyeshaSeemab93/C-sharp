﻿namespace Exercise006
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // Implement a program, or modify the program so, that it causes 
            // the NullReferenceException -error


            List<string> lines = new List<string>();
            lines.Add("Never has a man influenced physics so profoundly as Niels Bohr in the early 1900's");
            lines.Add("Going back to this time period, little was known about atomic structure; Bohr set out");
            lines.Add("to end the obscurity of physics. However, things didn't come easy for Bohr. He had to");
            lines.Add("give up most of his life for physics and research of many hypothesis. But, this is why");
            lines.Add("you and I have even heard of the quantum theory and atomic structures. Bohr came");
            lines.Add("up with his quantum theory while studying...");


            lines = null;
            int index = 0;
            while (index < lines.Count)
            {
                Console.WriteLine(lines[index]);
                index++;
            }
        }
    }
}