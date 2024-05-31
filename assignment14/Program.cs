
using System;
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
