namespace Exercise015
{
    public class Money
    {

        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            this.euros = euros;
            this.cents = cents;
        }

        public Money Plus(Money addition)
        {
            // create a new Money object that has the correct worth
            Money newMoney = new Money(this.euros, this.cents);
            newMoney.euros += addition.euros;
            newMoney.cents += addition.cents;
            if (newMoney.cents > 100)
            {
                // If the value of cents is greater than 100, substract 100 cents and increase euros by 1
                newMoney.cents = newMoney.cents - 100;
                newMoney.euros++;
            }
            // return the new Money object
            return newMoney;
        }

        public Money Minus(Money decreaser)
        {
            Money newMoney = new Money(this.euros, this.cents);
            // create a new Money object that has the correct worth
            newMoney.euros -= decreaser.euros;
            newMoney.cents -= decreaser.cents;
            if (newMoney.cents < 0)
            {
                // Add the negative cents to 100, e.g. 100 + (-10) = 90
                newMoney.cents = 100 + newMoney.cents;
                newMoney.euros--;
            }

            if (newMoney.euros < 0)
            {
                // Set the value of euros & cents to 0
                newMoney.euros = newMoney.cents = 0;
            }
            // return the new Money object
            return newMoney;
        }

        public bool LessThan(Money compared)
        {
            if (this.euros < compared.euros)
            {
                return true;
            }
            else if (this.euros == compared.euros && this.cents < compared.cents)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            string zero = "";
            if (this.cents <= 10)
            {
                zero = "0";
            }
            return this.euros + "." + zero + this.cents + "e";
        }
    }
}