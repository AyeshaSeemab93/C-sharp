namespace Exercise011
{
    public class Song
    {
        private string artist;
        private string name;
        private int durationInSeconds;

        public Song(string artist, string name, int durationInSeconds)
        {
            this.artist = artist;
            this.name = name;
            this.durationInSeconds = durationInSeconds;
        }
        // Equals Mehtod
        public override bool Equals(Object anotherSparrow)
        {
            // check address
            if (this == anotherSparrow)
            {
                return true;
            }

            // check if null || compare object types
            if (anotherSparrow == null || !this.GetType().Equals(anotherSparrow.GetType()))
            {
                return false;
            }
            // Type cast
            Song anotherSparrowSong = (Song)anotherSparrow;
            //compare variables
            if (
                this.artist == anotherSparrowSong.artist &&
                this.name == anotherSparrowSong.name &&
                this.durationInSeconds == anotherSparrowSong.durationInSeconds
            )
            {
                return true;
            }

            return false;
        }




        public override string ToString()
        {
            return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
        }


    }
}