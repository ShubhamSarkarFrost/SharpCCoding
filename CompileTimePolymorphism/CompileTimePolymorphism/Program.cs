namespace CompileTimePolymorphism
{
    class geometry
    {
        public double area(double side)  //square
        {
            return side * side;
        }

        public double area(double length, double breadth)// reactangle
        {
            return length * breadth;
        }

        public double area(double a, double b, double c)  // Triangle (Heron's formula)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }


    }
     internal class Program
    {
        static void Main(string[] args)
        {
            geometry geo = new geometry();
            Console.WriteLine("Square - Area: " + geo.area(12.56));
            Console.WriteLine("Rectangle Area: " + geo.area(12, 7));
            Console.WriteLine("Triangle Area :" + geo.area(5, 6, 7));
            Console.ReadKey();
        }
    }
}
