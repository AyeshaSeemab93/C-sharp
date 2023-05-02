namespace Exercise003
{
    using System;

    public class Fitbyte
    {
        public double age;
        public double restingHR;
        public double targetHR;
        public double maxHR;

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHR = restingHeartRate;
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            this.maxHR = 206.3 - (0.711 * this.age);

            targetHR = (this.maxHR - this.restingHR) * percentageOfMaximum + restingHR;

            return this.targetHR;
        }



    }
}