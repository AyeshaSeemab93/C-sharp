namespace Exercise012
{
    using System;
    public class Multiplier
    {
        private int number;
        //constructor
        public Multiplier(int number)
        {
            this.number = number;
        }
        //method
        public int Multiply(int number)
        {
            this.number = this.number * number;
            return this.number;
        }
    }


}