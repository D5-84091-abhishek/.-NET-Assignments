using Q8;
namespace Q10
{
    public class Supervisor : Employee
    {
		private int subordinates;
		public int Subordinates
		{
			get { return subordinates; }
			set { subordinates = value; }
		}
        public Supervisor()
        {
            Designation = "Supervisor";
        }
        public Supervisor(int subordinates)
        {
            this.subordinates = subordinates;
            Designation = "Supervisor";
        }
        public override void Accept()
        {
            base.Accept();
            Designation = "Supervisor";
            Console.Write("Enter Subordinates : ");
            Subordinates = Convert.ToInt32(Console.ReadLine());
        }
        public override void Print()
        {
            Console.WriteLine("\nSupervisor Details :" + "\n" + ToString());
        }
        public override string ToString()
        {
            return base.ToString()+" \nNo. of Subordinates = "+Subordinates +".";
        }
    }
}
