namespace Exercise001
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Account myAccount = new Account("Ayesha's Account", 100.0);
            myAccount.Deposit(20.0);
            Console.WriteLine(myAccount.balance);
        }
    }
}
