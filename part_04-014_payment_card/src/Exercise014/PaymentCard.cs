
namespace Exercise014
{
    public class PaymentCard
    {
        private double balance;
        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        }


        public override string ToString()
        {

            return "The card has a balance of " + this.balance + " euros";

        }
        public void EatLunch()
        {
            if (this.balance >= 10.60)
            { this.balance = this.balance - 10.60; }
        }
        public void DrinkCoffee()
        {
            if (this.balance >= 2.0)
            { this.balance = this.balance - 2.0; }
        }
        public void AddMoney(double amount)
        {
            if (amount > 0 && amount < 150)
            { this.balance = this.balance + amount; }
            else if (amount > 150)
            {
                this.balance = 150;
            }
        }
    }
}