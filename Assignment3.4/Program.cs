namespace Assignment3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter seconds :");
            long seconds = Convert.ToInt64(Console.ReadLine());

            long minute = seconds / 60;
            long hour = minute / 60;
            long day = hour / 24;

            Console.WriteLine(" the second you entered is equal to minute = " + minute);
            Console.WriteLine(" the second you entered is equal to hour = " + hour);
            Console.WriteLine(" the second you entered is equal to day = " + day);


            Console.ReadLine();
        }
    }
}
