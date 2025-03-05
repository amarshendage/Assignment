namespace ConsoleApp38
{
    internal class Program
    {
        static void Main()
        {
                
                Console.WriteLine("Enter height in inches: ");
                double heightInInches = Convert.ToDouble(Console.ReadLine());

                
                double heightInCm = heightInInches * 2.54;

                
                string category;
                if (heightInCm < 150)
                {
                    category = "Dwarf";
                }
                else if (heightInCm >= 150 && heightInCm < 165)
                {
                    category = "Average height";
                }
                else if (heightInCm >= 165 && heightInCm < 195)
                {
                    category = "Tall";
                }
                else
                {
                    category = "Abnormal height";
                }

                
                Console.WriteLine("Height category: " + category);
            
        }







    }
}
}
