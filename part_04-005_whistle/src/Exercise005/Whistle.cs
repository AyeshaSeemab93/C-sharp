namespace Exercise005
{
    using System;
    public class Whistle
    {
        private string sound;

        public Whistle(string whistleSound)
        {
            this.sound = whistleSound;
        }
        public void Sound()
        {
            Console.WriteLine(this.sound);
        }
    }
}