namespace Exercise003
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            //object
            Fitbyte assistant = new Fitbyte(30, 60);
            //giving input to method
            double percentage = 0.5;

            //calling the method here & saving return type in variable
            //double maximum = assistant.maxHeartRate();

            while (percentage < 1.0)
            {
                //calling the method here & saving return type in variable
                double target = assistant.TargetHeartRate(percentage);

                Console.WriteLine("Target " + (percentage * 100) + "% of maximum: " + target);
                percentage = percentage + 0.1;
            }
        }
    }
}