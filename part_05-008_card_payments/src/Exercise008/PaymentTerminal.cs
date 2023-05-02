namespace Exercise008
{
    public class PaymentTerminal
    {
        public double money { get; private set; }  // amount of cash
        public int coffeeAmount { get; private set; } // number of sold coffees
        public int lunchAmount { get; private set; }  // number of sold lunches

        public PaymentTerminal()
        {
            this.money = 1000;
            this.coffeeAmount = 0;
            this.lunchAmount = 0;
        }
        /*FOR CASH PAYMENTS*/
        public double DrinkCoffee(double payment)
        {
            if (payment < 2.50)
            {
                return payment;
            }
            else
            {
                this.money = this.money + 2.50;

                this.coffeeAmount++;
                return payment - 2.50;
            }

        }

        public double EatLunch(double payment)
        {
            if (payment >= 10.30)
            {
                this.money = this.money + 10.30;
                this.lunchAmount++;

                return payment - 10.30;
            }
            else
                return payment;
        }

        /*FOR CARD PAYMENTS*/
        public bool DrinkCoffee(PaymentCard card)
        {

            if (card.balance >= 2.50)
            {
                card.TakeMoney(2.50);
                this.coffeeAmount++;

                return true;
            }
            else
                return false;
            // a coffee costs 2.50 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned

        }

        public bool EatLunch(PaymentCard card)
        {
            if (card.balance >= 10.30)
            {
                card.TakeMoney(10.30);
                this.lunchAmount++;

                return true;
            }
            else
                return false;
            // a lunch costs 10.30 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned

        }
        public void AddMoneyToCard(PaymentCard card, double sum)
        {
            if (sum > 0)
            {
                this.money = this.money + sum;
                card.AddMoney(sum);
            }
            // Only add positive amounts
        }

        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}