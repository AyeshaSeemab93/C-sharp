namespace Exercise008
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Debt mortgage = new Debt(120000.0, 1.01);
            mortgage.PrintBalance();

            mortgage.WaitOneYear();
            mortgage.PrintBalance();
            // interest rate After 20 years
            int i = 0;
            while (i < 20)
            {
                mortgage.WaitOneYear();
                i++;
            }
            mortgage.PrintBalance();

        }

    }
}