
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace Question16
{


    namespace Question14
    {
       
      

        public enum DepartmentType
        {
            HR,
            IT,
            Finance
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

       

[Serializable]
        public class Employee : Person
        {
            private static int count = 0;
            public int Id { get; private set; }
            public double Salary { get; set; }
            public string Designation { get; set; }
            public DepartmentType Dept { get; set; }

            public Employee()
            {
                Id = ++count;
            }

            public Employee(double salary, string designation, DepartmentType dept) : this()
            {
                Salary = salary;
                Designation = designation;
                Dept = dept;
            }

            public virtual void Accept()
            {
                Console.WriteLine("Enter Name: ");
                Name = Console.ReadLine();

                Console.WriteLine("Enter Age: ");
                Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Salary: ");
                Salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Designation: ");
                Designation = Console.ReadLine();

                Console.WriteLine("Enter Department (0: HR, 1: IT, 2: Finance): ");
                Dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), Console.ReadLine());
            }

            public virtual void Print()
            {
                Console.WriteLine(ToString());
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, Designation: {Designation}, Department: {Dept}";
            }
        }




        public class Manager : Employee
        {
            public double Bonus { get; set; }

            public Manager() : base()
            {
                Designation = "Manager";
            }

            public Manager(double salary, DepartmentType dept, double bonus) : base(salary, "Manager", dept)
            {
                Bonus = bonus;
            }

            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("Enter Bonus: ");
                Bonus = Convert.ToDouble(Console.ReadLine());
            }

            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Bonus: {Bonus}");
            }

            public override string ToString()
            {
                return base.ToString() + $", Bonus: {Bonus}";
            }
        }



        public class Supervisor : Employee
        {
            public int Subordinates { get; set; }

            public Supervisor() : base()
            {
                Designation = "Supervisor";
            }

            public Supervisor(double salary, DepartmentType dept, int subordinates) : base(salary, "Supervisor", dept)
            {
                Subordinates = subordinates;
            }

            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("Enter Number of Subordinates: ");
                Subordinates = Convert.ToInt32(Console.ReadLine());
            }

            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Subordinates: {Subordinates}");
            }

            public override string ToString()
            {
                return base.ToString() + $", Subordinates: {Subordinates}";
            }
        }


        public class WageEmp : Employee
        {
            public int Hours { get; set; }
            public int Rate { get; set; }

            public WageEmp() : base()
            {
                Designation = "Wage";
            }

            public WageEmp(double salary, DepartmentType dept, int hours, int rate) : base(salary, "Wage", dept)
            {
                Hours = hours;
                Rate = rate;
            }

            public override void Accept()
            {
                base.Accept();
                Console.WriteLine("Enter Hours: ");
                Hours = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Rate: ");
                Rate = Convert.ToInt32(Console.ReadLine());
            }

            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Hours: {Hours}, Rate: {Rate}");
            }

            public override string ToString()
            {
                return base.ToString() + $", Hours: {Hours}, Rate: {Rate}";
            }
        }



        [Serializable]
        public class Company
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public ArrayList EmpList { get; set; }
            public double SalaryExpense { get; private set; }

            public Company()
            {
                EmpList = new ArrayList();
            }

            public Company(string name, string address) : this()
            {
                Name = name;
                Address = address;
            }

            public void CalculateSalaryExpense()
            {
                SalaryExpense = 0;
                foreach (Employee emp in EmpList)
                {
                    SalaryExpense += emp.Salary;
                }
            }

            public void AddEmployee(Employee e)
            {
                EmpList.Add(e);
                CalculateSalaryExpense();
            }

            public bool RemoveEmployee(int id)
            {
                Employee empToRemove = null;
                foreach (Employee emp in EmpList)
                {
                    if (emp.Id == id)
                    {
                        empToRemove = emp;
                        break;
                    }
                }

                if (empToRemove != null)
                {
                    EmpList.Remove(empToRemove);
                    CalculateSalaryExpense();
                    return true;
                }
                return false;
            }

            public Employee FindEmployee(int id)
            {
                foreach (Employee emp in EmpList)
                {
                    if (emp.Id == id)
                    {
                        return emp;
                    }
                }
                return null;
            }
            public void Print()
            {
                Console.WriteLine(this.ToString());
            }

            public override string ToString()
            {
                return $"Name: {Name}, Address: {Address}, SalaryExpense: {SalaryExpense}";
            }

            public void PrintEmployees()
            {
                foreach (Employee emp in EmpList)
                {
                    emp.Print();
                }
            }
        }


    }

 
namespace Question14
    {


        class Program
        {
            static void Main()
            {
                Company company = new Company();
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. Remove Employee");
                    Console.WriteLine("3. Find Employee by ID");
                    Console.WriteLine("4. Display Company Info");
                    Console.WriteLine("5. Display All Employees");
                    Console.WriteLine("6. Exit");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Employee Type (1: Manager, 2: Supervisor, 3: WageEmp): ");
                            int type = Convert.ToInt32(Console.ReadLine());
                            Employee emp;
                            switch (type)
                            {
                                case 1:
                                    emp = new Manager();
                                    break;
                                case 2:
                                    emp = new Supervisor();
                                    break;
                                case 3:
                                    emp = new WageEmp();
                                    break;
                                default:
                                    Console.WriteLine("Invalid type");
                                    continue;
                            }
                            emp.Accept();
                            company.AddEmployee(emp);
                            break;

                        case 2:
                            Console.WriteLine("Enter Employee ID to Remove: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            if (company.RemoveEmployee(id))
                            {
                                Console.WriteLine("Employee removed successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Employee not found.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter Employee ID to Find: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            var empFound = company.FindEmployee(id);
                            if (empFound != null)
                            {
                                empFound.Print();
                            }
                            else
                            {
                                Console.WriteLine("Employee not found.");
                            }
                            break;

                        case 4:
                            company.Print();
                            break;

                        case 5:
                            company.PrintEmployees();
                            break;

                        case 6:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
            }
        }

    }

}
