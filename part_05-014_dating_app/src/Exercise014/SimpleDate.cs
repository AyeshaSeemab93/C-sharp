namespace Exercise014
{
    public class SimpleDate
    {
        private int day;
        private int month;
        private int year;

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void Advance()
        {
            //first check all conditions then increase date
            if (this.day == 30)
            {
                this.day = 1;
                if (this.month == 12)
                {
                    this.month = 1;
                    this.year++;
                }
                else
                {
                    this.month++;
                }
            }
            else
            {
                this.day++;
            }
            // also alright but loop holes(1st inc date to 31 then bring down to 1)advance 1 date but if date is 30 then month change and if month= 12, then year change

            // if (this.day <= 30)
            // {
            //     this.day += 1;
            // }
            // if (this.day > 30)
            // {
            //     this.day = 1;
            //     this.month += 1;
            //     if (this.month > 12)
            //     {
            //         this.month = 1;
            //         this.year += 1;
            //     }

        }


        public void Advance(int howManyDays)
        {
            //advance the date until the howmanydays(eg 7days) 
            for (int i = 1; i <= howManyDays; i++)
            {
                this.Advance();
            }
        }

        public SimpleDate AfterNumberOfDays(int days)
        {
            SimpleDate newDate = new SimpleDate(this.day, this.month, this.year);
            newDate.Advance(days);
            return newDate;
        }


        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }

        // used to check if this date object (`this`) is before
        // the date object given as the parameter (`compared`)
        public bool Before(SimpleDate compared)
        {
            // first compare years
            if (this.year < compared.year)
            {
                return true;
            }

            // if the years are the same, compare months
            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }

            // the years and the months are the same, compare days
            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }

            return false;
        }
    }
}
