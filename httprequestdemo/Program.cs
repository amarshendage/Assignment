namespace HttprequestDemo
{
    internal class Program
    {
        static async Task GetHttpRequestDemo()
        {


             System.Console.WriteLine("Enter the username");
            string name = System. Console.ReadLine();

            System.Console.WriteLine("Enter the password");
            string password =   System.Console.ReadLine();

            var httpClient = new HttpClient();

            //var httpRequestMsg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7236/user/addUser/amar/amar%40123");
            var httpRequestMsg = new HttpRequestMessage(HttpMethod.Get, $"https://localhost:7236/user/addUser/{name}/{password}");

            var response = httpClient.Send(httpRequestMsg);

            response.EnsureSuccessStatusCode();

            Console.WriteLine(response.StatusCode.ToString());

            var resultData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            Console.WriteLine(resultData);

            Console.WriteLine("Get Request");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            GetHttpRequestDemo();
        }
    }
}

