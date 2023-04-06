namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory.GetVehicle(4);
            Console.WriteLine("Hello, World!");
        }
    }
}
