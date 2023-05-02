
// DO NOT TOUCH THE CODE IN HERE

namespace Exercise017
{
    using System;
    public class TelevisionProgram
    {

        public string name { get; set; }
        public int duration { get; set; }


        public TelevisionProgram(string name, int duration)
        {
            this.name = name;
            this.duration = duration;


        }
        // No need to make new function but its alright
        //public void PrintProgram(int maxDuration)
        // {
        //     if (this.duration <= maxDuration)
        //     {
        //         Console.WriteLine(ToString());
        //     }
        // }

        public override string ToString()
        {
            return this.name + ", " + this.duration + " minutes";
        }
    }
}