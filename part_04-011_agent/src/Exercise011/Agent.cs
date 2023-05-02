namespace Exercise011
{
    public class Agent
    {
        private string firstName;
        private string lastName;

        public Agent(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {

            return "My name is " + this.lastName + ". " + this.firstName + " " + this.lastName + ".";
            // Should return for example "My name is Bond. James Bond."


        }
    }
}