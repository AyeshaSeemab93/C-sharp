namespace Exercise007
{
    using System;
    public class DecreasingCounter
    {
        private int value;   // a variable that remembers the value of the counter

        public DecreasingCounter(int initialValue)
        {
            this.value = initialValue;
        }

        public void PrintValue()
        {
            Console.WriteLine("value: " + this.value);
        }

        public void Decrement()
        {
            if (this.value > 0)
            { this.value = this.value - 1; }
        }

        public void Reset()
        {
            this.value = 0;
        }
    }
}

