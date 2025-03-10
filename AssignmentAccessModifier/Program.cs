namespace AssignmentAccessModifier
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Product productobject = new Product();
            Console.WriteLine(productobject.productId);

            productobject.test();
        }
    }
}
