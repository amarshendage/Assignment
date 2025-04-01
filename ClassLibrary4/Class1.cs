 public class SqlDbConnection : System.IDisposable
{
    public SqlDbConnection()
    {
       System.Console.WriteLine("Connection established with sql server");
    }
    public void getDatabaseObjects()
    {
        System.Console.WriteLine("fetched the data from database ");
    }
    public void Dispose() 
    {

        System.Console.WriteLine("Database connction destroyed");
    }
}
