namespace Exercise004
{
    using System;
    public class Room
    {
        private string code;
        private int seats;
        //construct
        public Room(string classCode, int numberOfSeats)
        {
            this.code = classCode;
            this.seats = numberOfSeats;

        }
    }
}