/*Write a class Employee with following members:  
int id; (Auto Generated)  
double salary;   string designation; 
enum DepartmentType dept; 
  */
using Q7;
namespace Q8
{
    public enum DepartmentType
    {
        Administration=1, HR, Finance, Development, Sales, II
    }
    public class Employee : Person
    {
        private int id;
		private double salary;
		private string designation;
        private DepartmentType dept;
        private static int genid = 1;
        public int Id
        {
            get { return id; }
        }
        public DepartmentType Dept
		{
			get { return dept; }
			set { dept = value; }
		}
		public string Designation
		{
			get { return designation; }
			set { designation = value; }
		}
		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}
        public Employee()
        {
            this.id = genid;
            genid++;
        }
        public Employee(double salary , string designation , DepartmentType dept)
        {
            this.id = genid;
            genid++;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }
        public override void Accept() {
           base.Accept();
            Console.Write("Enter Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Designation : ");
            Designation = Console.ReadLine();
            Console.WriteLine("Departments : ");
            Console.WriteLine("1.Administration, 2.HR, 3.Finance, 4.Development, 5.Sales, 6.II");
            Console.Write("Enter Department ( between 1 to 6): ");
            int deptno = Convert.ToInt32(Console.ReadLine());
            Dept = (DepartmentType)deptno;
        }
        public override string ToString()
        {
            return base.ToString()+ "\nEmployment Details : ID = "+Id +", Salary = "+Salary+", Designation = "+Designation+", Department = "+Dept  ;
        }
        public override void Print()
        {
            Console.WriteLine("Employee Details : \n" + "\n" + ToString());
        }
    }
}
