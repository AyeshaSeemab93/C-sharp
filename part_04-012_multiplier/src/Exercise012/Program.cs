namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Multiplier multiplyByThree = new Multiplier(3);
            Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));



            Multiplier multiplyByFour = new Multiplier(4);

            Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));

            Multiplier multiplyBySix = new Multiplier(6);
            Console.WriteLine("multiplyBySix.Multiply(1): " + multiplyBySix.Multiply(1));
            Multiplier multiplyByEight = new Multiplier(8);
            Console.WriteLine("multiplyByEight.Multiply(1): " + multiplyByEight.Multiply(1));
            Console.WriteLine("multiplyByEight.Multiply(3): " + multiplyByEight.Multiply(3));
        }
    }
}