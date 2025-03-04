namespace Assignment1._2
{
    internal class PersonHeight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the feet : ");
            decimal feet = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the inches : ");
            decimal inches = Convert.ToDecimal(Console.ReadLine());

            decimal feetinches = ((feet * 12) + (inches)) * (decimal)2.54;

            Console.WriteLine(feetinches + "cm");
            Console.ReadLine();



        }
    }
}

