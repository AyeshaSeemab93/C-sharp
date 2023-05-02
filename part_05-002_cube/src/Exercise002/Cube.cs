namespace Exercise002
{
    using System;
    public class Cube
    {
        //variable
        private int length;
        private int volume;
        //construct
        public Cube(int edgeLength)
        {
            this.length = edgeLength;
        }
        //method
        public int Volume()
        {
            volume = this.length * this.length * this.length;
            return this.volume;
        }
        // toString
        public override string ToString()
        {
            return $"The length of the edge is {this.length} and the volume {this.Volume()}";
        }

    }
}