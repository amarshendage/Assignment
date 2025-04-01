namespace assignmentarrraypractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 7, 1, 13, 4 };
            int length = arr.Length;
             int max = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();

        }
    }
}