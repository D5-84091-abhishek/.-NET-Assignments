using Q8;

namespace Q11
{
    public class WageEmp : Employee
    {
		private int rate;
        private int hours;
        public int Rate
		{
			get { return rate; }
			set { rate = value; }
		}
		public int Hours
		{
			get { return hours; }
			set { hours = value; }
		}
        public WageEmp()
        {
            Designation = "Wage";
        }
        public WageEmp(int hour,int rate)
        {
            this.rate = rate;
            this.hours = hour;
            Designation = "Wage";
        }
        public override void Accept()
        {
            base.Accept();
            Designation = "Wage";
            Console.Write("Enter Wage : ");
            Rate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Hours : ");
            Hours  = Convert.ToInt32(Console.ReadLine());
            Salary = rate * hours;
        }
        public override void Print()
        {
            Console.WriteLine("\nWage Employee : \n"+ToString());
        }
        public override string ToString()
        {
            return base.ToString()+"\n"+"(Salary is not fixed as it is calculated on wage*hours) {"+Rate+"*"+Hours+"}";
        }
    }
}
