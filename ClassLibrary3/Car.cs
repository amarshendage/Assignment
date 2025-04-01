using System.Security.AccessControl;

public class car
{
    public string carname;
    public int carprice;

    public void getCarDetails()
    {
        Console.WriteLine("Car Name: " + carname);
        Console.WriteLine("Car Price: " + carprice);

    }
}

