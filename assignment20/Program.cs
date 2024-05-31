using Question20;
using Question8;
using System;



namespace Question20
{
 
    public class Company
    {
        // Other properties and methods...

        // Event declaration
        public event EventHandler EmpListChanged;

        // Method to raise the event
        protected virtual void OnEmpListChanged()
        {
            EmpListChanged?.Invoke(this, EventArgs.Empty);
        }

        // Method to add an employee
        public void AddEmployee(Employee e)
        {
            EmpList.Add(e);
            CalculateSalaryExpense();
            OnEmpListChanged(); // Raise the event
        }

        // Method to remove an employee
        public bool RemoveEmployee(int id)
        {
            // Remove logic
            OnEmpListChanged(); // Raise the event
        }
    }

  
    internal class Program
    {
            static void Main()
            {
                Company company = new Company();

                // Subscribe to the EmpListChanged event
                company.EmpListChanged += Company_EmpListChanged;

                // Other code...
            }

            // Event handler
            private static void Company_EmpListChanged(object sender, EventArgs e)
            {
                // Update salary expense logic
                Console.WriteLine("Employee list changed. Updating salary expense...");
            }
        }
}
