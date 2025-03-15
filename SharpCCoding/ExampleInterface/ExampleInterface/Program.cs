namespace ExampleInterface
{

    interface IVehicle
    {
        void Start();  // Start the vehicle
        void Stop();   // Stop the vehicle
        void Rent(int days); // Rent the vehicle for a certain number of days
    }

    // Car class implementing IVehicle
    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped.");
        }

        public void Rent(int days)
        {
            Console.WriteLine($"Car rented for {days} days.");
        }
    }

    // Bike class implementing IVehicle
    class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike started.");
        }

        public void Stop()
        {
            Console.WriteLine("Bike stopped.");
        }

        public void Rent(int days)
        {
            Console.WriteLine($"Bike rented for {days} days.");
        }
    }

    // Truck class implementing IVehicle
    class Truck : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Truck started.");
        }

        public void Stop()
        {
            Console.WriteLine("Truck stopped.");
        }

        public void Rent(int days)
        {
            Console.WriteLine($"Truck rented for {days} days.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle myVehicle;

            // Rent a Car
            myVehicle = new Car();
            myVehicle.Start();
            myVehicle.Rent(5);
            myVehicle.Stop();

            Console.WriteLine();

            // Rent a Bike
            myVehicle = new Bike();
            myVehicle.Start();
            myVehicle.Rent(2);
            myVehicle.Stop();

            Console.WriteLine();

            // Rent a Truck
            myVehicle = new Truck();
            myVehicle.Start();
            myVehicle.Rent(7);
            myVehicle.Stop();
            Console.ReadKey();
        }
    }
}
