namespace assignmenetconstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee( "john","sg",1);   
            Employee e2 = new Employee( "nelu","developer",2);   
            Employee e3 = new Employee( "ram","wdvjhq",3);   

            System.Console.WriteLine("Employee e1 :");
            System.Console.WriteLine(e1.empName);
            System.Console.WriteLine(e1.job);
            System.Console.WriteLine(e1.empID);

            System.Console.WriteLine("Employee e2 :");
            System.Console.WriteLine(e2.empName);
            System.Console.WriteLine(e2.job);
            System.Console.WriteLine(e2.empID);

            System.Console.WriteLine("Employee e3 :");
            System.Console.WriteLine(e3.empName);
            System.Console.WriteLine(e3.job);
            System.Console.WriteLine(e3.empID);



            Console.ReadLine();

        }
    }
}
