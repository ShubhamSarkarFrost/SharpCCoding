namespace IVehicleInterface
{   
    public interface IVehicle<T>
    {
        void Drive(T vehicle);
    }

    public class Car : IVehicle<int>
    {
        public void Drive(int vehicle)
        {
            Console.WriteLine($"Car is driving {vehicle} km/hr");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle<int> myCar = new Car();
            myCar.Drive(24);

            IVehicle<int> myNewCar = new Car();
            myNewCar.Drive(200);

            Console.ReadKey();
        }
    }
}
