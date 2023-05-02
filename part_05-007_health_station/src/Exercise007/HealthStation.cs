namespace Exercise007
{
    public class HealthStation
    {
        public int weighings { get; private set; }


        // Create a constructor here, if needed

        public int Weigh(Person person)
        {

            this.weighings++;
            return person.weight;

        }
        public void Feed(Person person)
        {
            person.weight = person.weight + 1;
            //change the virable value of person class(object)

        }

    }
}