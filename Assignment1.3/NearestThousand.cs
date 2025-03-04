namespace Assignment1._3
{
    internal class NearestThousand
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
             int  number = Convert.ToInt32(Console.ReadLine());
            int NearestThousand = (number + 500) / 1000 * 1000;
            Console.WriteLine( NearestThousand == 0 ?" Nearest thousand is :1000" :$"Nearest thousand is : { NearestThousand}");
            Console.ReadLine();





        }


    }
}

