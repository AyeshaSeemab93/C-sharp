namespace Exercise005
{
    using System;
    public class Counter
    {
        public int value { get; set; }
        //Constructors
        public Counter(int startValue)
        {
            this.value = startValue;
        }

        public Counter()
        {
            this.value = 0;
        }

        //Methods
        public void Increase()
        {
            this.value++;
        }

        public void Increase(int increaseBy)
        {
            if (increaseBy >= 0)
            {
                this.value = value + increaseBy;
            }
        }

        public void Decrease()
        {
            this.value--;
        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy >= 0)
            {
                this.value = value - decreaseBy;
            }
        }

    }









}