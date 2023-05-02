namespace Exercise005
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {


            Counter counter = new Counter();
            Console.WriteLine(counter.value);
            counter.Increase();
            Console.WriteLine(counter.value);
            counter.Increase(9);
            Console.WriteLine(counter.value);
            counter.Increase(-9);
            Console.WriteLine(counter.value);
            counter.Decrease();
            Console.WriteLine(counter.value);
            counter.Decrease(5);
            Console.WriteLine(counter.value);
        }

    }
}