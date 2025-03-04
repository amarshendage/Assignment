namespace Assignment1
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
           const  decimal pi = 3.14M;
            //int radius = 20;
            Console.WriteLine("enter the radius of circle :");
            int radius = Convert.ToInt32(Console.ReadLine());
            
            decimal area = pi * radius * radius;
            Console.WriteLine("Area of circle is :" + area);
            Console.ReadLine();
        }
    }
}
