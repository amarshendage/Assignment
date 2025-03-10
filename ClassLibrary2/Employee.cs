namespace ClassLibrary2

{
    public class Employee
    {
        public int EmpID;
        public string EmpName;
        public double SalaryPerHour;
        public double NoOfWorkingHours;
        public double NetSalary;

        public static string OrganizationName = "Harsha Inc.";

        public const string TypeOfEmployee = "Contract Based";

        public readonly string DepartmentName;
        public Employee()
        {
            DepartmentName = "Finance Department";
        }
        public void CalculateNetSalary()
        {
            NetSalary = SalaryPerHour * NoOfWorkingHours;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"EmpID: {EmpID}");
            Console.WriteLine($"EmpName: {EmpName}");
            Console.WriteLine($"SalaryPerHour: {SalaryPerHour}");
            Console.WriteLine($"NoOfWorkingHours: {NoOfWorkingHours}");
            Console.WriteLine($"NetSalary: {NetSalary}");
            Console.WriteLine($"OrganizationName: {OrganizationName}");
            Console.WriteLine($"TypeOfEmployee: {TypeOfEmployee}");
            Console.WriteLine($"DepartmentName: {DepartmentName}");
           
        }
        
    }
}


