namespace AssignIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("The largest number is: " + number1);
            }
            else if (number2 > number3)
            {
                Console.WriteLine("The largest number is: " + number2);
            }
            else
            {
                Console.WriteLine("The largest number is: " + number3);
            }
            
            Console.ReadLine();

        }
    }
}
