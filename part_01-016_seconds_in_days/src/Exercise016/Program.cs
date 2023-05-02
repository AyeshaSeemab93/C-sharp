namespace Exercise016
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            1 day = 24 hours
            1 hour = 60 min *60 =3600seconds
           1day = 24 hours = 24*3600 = 86400seconds


            */
            int days = 0;

            Console.WriteLine("How many days?");
            days = Convert.ToInt32(Console.ReadLine());

            int totalSeconds = days * (24 * 60 * 60);
            Console.WriteLine(totalSeconds);
        }
    }
}
