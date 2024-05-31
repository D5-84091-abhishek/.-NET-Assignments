using Q7;
using Q8;
using System.Threading.Channels;

namespace Q9
{
    public class Manager : Employee
    {
		private double bonus;

		public double Bonus
		{
			get { return bonus; }
			set { bonus = value; }
		}
        public Manager()
        {
            Designation = "Manager";
        }
        public Manager(double bonus)
        {
            this.bonus = bonus;
            Designation = "Manager";
        }
        public override void Accept()
        {
            base.Accept();
            Designation = "Manager";
            Console.Write("Enter Bonus : ");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public override void Print()
        {
            Console.WriteLine("\nManager Details : "+"\n"+ToString());
        }
        public override string ToString()
        {
            return base.ToString() + ", Bonus = "+bonus+", Total Salary = "+(Salary+Bonus)+" .";
        }
    }
}
