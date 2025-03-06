namespace assigenmentswitchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = null;
            string password = null;
            int choice = 1;


            Console.WriteLine("\n\n ::login page ");

            Console.WriteLine("Enter your username :");
             username = Console.ReadLine();

            if (username != "" && password != "'")
            {
                Console.WriteLine("Enter your password :");
                password = Console.ReadLine();

                if (username == "system" && password == "manager")
                {
                    Console.WriteLine("\n\n::main menu  :");
                    Console.WriteLine("1. Customer");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Fund Transfer");
                    Console.WriteLine("4. Fund Transfer Statement");
                    Console.WriteLine("5. Account Statement");
                    Console.WriteLine("0. Exit");
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Customer");
                            break;
                        case 2:
                            Console.WriteLine("Accounts");
                            break;
                        case 3:
                            Console.WriteLine("Fund Transfer");
                            break;
                        case 4:
                            Console.WriteLine("Fund Transfer Statement");
                            break;
                        case 5:
                            Console.WriteLine("Account Statement");
                            break;
                        default:
                            Console.WriteLine("Exit");
                            break;


                    }
                }
                
                else
                {
                    Console.WriteLine("Invalid username or password entered.");

                }

                Console.WriteLine("\n\n thank you ! visit again :");
                Console.ReadLine();

               
            }

        }
        
    } 
}


