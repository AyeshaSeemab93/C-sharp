namespace Exercise005
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Whistle duckWhistle = new Whistle("Kvaak");
            Whistle roosterWhistle = new Whistle("Peef");
            duckWhistle.Sound();
            roosterWhistle.Sound();
            duckWhistle.Sound();


        }
    }
}