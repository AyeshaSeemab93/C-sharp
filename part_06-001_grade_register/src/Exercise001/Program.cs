namespace Exercise001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GradeRegister register = new GradeRegister();

            UserInterface ui = new UserInterface(register);
            ui.Start();
        }
    }
}