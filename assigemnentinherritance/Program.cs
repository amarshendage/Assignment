using static assigemnentinherritance.employee;

namespace assigemnentinherritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.empId = 10;
            e1.empName = "Nisha";
            e1.location = "Pune";
            System.Console.WriteLine("Object of parent class Employee : ");
            System.Console.WriteLine(e1.empName);
            System.Console.WriteLine(e1.empId);
            System.Console.WriteLine(e1.location);



            Manager m1 = new Manager();
            m1.empId = 10;
            m1.empName = "Nisha";
            m1.location = "Pune";
            m1.department = "Accounting";
            System.Console.WriteLine("Object of parent class Manager : ");
            System.Console.WriteLine(m1.empName);
            System.Console.WriteLine(m1.empId);
            System.Console.WriteLine(m1.location);


            Console.ReadLine();
        }
    }
}
