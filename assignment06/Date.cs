namespace Q6
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;
        public int year
        {
            get { return _year; }
            set { _year = value; }
        }
        public int month
        {
            get { return _month; }
            set { _month = value; }
        }
        public int day
        {
            get { return _day; }
            set { _day = value; }
        }
        public Date()
        {

        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void AcceptDate()
        {
            Console.Write("Enter Day : ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month : ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if (isValid())
                Console.WriteLine("Successfully Added the Date : " + ToString());
            else
            {
                Console.WriteLine("INVALID DATE");
                day = 0;
                month = 0;
                year = 0;
            }
        }
        public void PrintDate()
        {
            Console.WriteLine("Date :" + ToString());
        }
        public bool isValid()
        {
            if (month > 0 && month < 13)
            {
                if (year > 1000 && year <= 9999)
                {
                    if (day > 0 && day < 31)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static int operator -(Date end, Date start )
        {
            return (end.year - start.year - 1) +
                 (((end.month > start.month) ||
                 ((end.month == start.month) && (end.day >= start.day))) ? 1 : 0);
        }
            public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }
    }
}
