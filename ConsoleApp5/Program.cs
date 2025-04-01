using System;
namespace LogicalPrograms
{
    public class Program
      
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Count vowels in the string
            int vowelCount = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c)) vowelCount++;
            }

            Console.WriteLine($"Number of vowels: {vowelCount}");
            Console.ReadLine();

        }
    }

}





