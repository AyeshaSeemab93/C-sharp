namespace Exercise001
{
    public class Timer
    {
        private ClockHand seconds;
        private ClockHand hundredSec;


        public Timer()
        {
            this.hundredSec = new ClockHand(100);
            this.seconds = new ClockHand(60);

        }
        public void Advance()
        {

            this.hundredSec.Advance();
            if (this.hundredSec.value == 0)
            {
                this.seconds.Advance();

            }
        }

        public override string ToString()
        {
            return this.seconds + ":" + this.hundredSec;




        }

    }
}




