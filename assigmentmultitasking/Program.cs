namespace assigmentmultitasking
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Main thread id : " + Thread.CurrentThread.ManagedThreadId);
                Task task1 = new Task(() => PrintPlus(200));
                Task task2 = new Task(() => PrintMinus(200));

                task1.Start();
                task2.Start();
                Console.WriteLine("Program is finished.");
                Console.ReadKey();
            }
        static int CalculateLength(string input)
        {
            Console.WriteLine("CalculateLength thread id : " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            return input.Length;
        }



        static void PrintPlus(int n)
            {
                Console.WriteLine("Print plus thread id : " + Thread.CurrentThread.ManagedThreadId);

                for (int i = 0; i < n; i++)
                {
                    Console.Write("+");
                }
            }

            static void PrintMinus(int n)
            {
                Console.WriteLine("Print minus thread id : " + Thread.CurrentThread.ManagedThreadId);

                for (int i = 0; i < n; i++)
                {
                    Console.Write("-");
                }
            }
        
    }
}
