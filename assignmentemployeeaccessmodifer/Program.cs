using System;
using ClassLibrary2;
namespace assignmentemployeeaccessmodifer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];
            int employeeCount = 0;
            bool continueInput = true;

            while (employeeCount < 10 && continueInput)
            {
                Employee emp = new Employee();


                Console.Write("Enter EmpID: ");
                emp.EmpID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter EmpName: ");
                emp.EmpName = Console.ReadLine();

                Console.Write("Enter Salary Per Hour: ");
                emp.SalaryPerHour = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Number of Working Hours: ");
                emp.NoOfWorkingHours = Convert.ToDouble(Console.ReadLine());
                emp.CalculateNetSalary();
                emp.DisplayEmployeeDetails();

                Console.Write("Do you want to continue to next employee (Yes/No)? ");
                string response = Console.ReadLine();
                if (response.ToLower() != "yes")
                {
                    continueInput = false;
                }

                employeeCount++;
            }
        }
    }
}
