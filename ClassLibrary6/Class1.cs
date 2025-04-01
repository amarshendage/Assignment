namespace ClassLibrary6
{
    public class Employee 
    {
        public string empName{ get; set; }
        public int empId { get; set; }
        public string location { get; set; }

        public class Manager : Employee
        {

            public string department { get; set; }

            public long getSalesOfYear()
            {
                return 1000;
            }
        }

        public class Salesman : Employee
        {
            public string region { get; set; }

            public long GetSalesOfTheCurrentMonth()
            {
                return 100;
            }

        }

    }



}
