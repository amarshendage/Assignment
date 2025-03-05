namespace assignment_swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = 10 , b = 15;
            Console.WriteLine("before swap"+"a = " + a + " b = " + b);
            //a = a + b;
            //b = a - b;
            //a = a - b;

            //a = a ^ b;
            //b = a ^ b;
            //a = a ^ b;

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("after sawp"+"a = " + a + " b = " + b);
            Console.ReadLine();
        }
    }
}
