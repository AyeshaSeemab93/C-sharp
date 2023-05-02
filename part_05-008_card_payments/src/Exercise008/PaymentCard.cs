namespace Exercise008
{
    public class PaymentCard
    {
        public double balance { get; private set; }
        //construtor to keep eye on balance
        public PaymentCard(double balance)
        {
            this.balance = balance;
        }

        //adding money
        public void AddMoney(double increase)
        {
            if (increase > 0)
            {
                this.balance = this.balance + increase;
            }
        }
        //getting money out
        public bool TakeMoney(double amount)
        {
            if (this.balance > amount)
            {
                this.balance = this.balance - amount;
                return true;
            }
            else
                return false;
        }
    }
}