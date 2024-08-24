namespace DemoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Car audi = new Car("X3","Sedan","BMW");
            audi.Model = "e-tron GT";
            audi.Brand = "Audi";
            audi.Type = "SuperCar";
            audi.displayModel(); */

            Car newcar = new Car("Hypersport", "Supercar", "Lycan");
            newcar.displayModel();
            Console.ReadKey();
            
        }
    }
}
