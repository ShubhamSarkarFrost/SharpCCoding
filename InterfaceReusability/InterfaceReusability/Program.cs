namespace InterfaceReusability
{   
    interface IShape
    {
        double Area();
        double Perimeter();
    }

    class square : IShape
    {
        private double side;
        public square(double side)
        {
            this.side = side;
        }
        public double Area()
        {
            return side * side;
        }

        public double Perimeter()
        {
            return 4 * side;
        }
    }

    class Rectangle : IShape
    {
        private double length, width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area() { return length * width; }

        public double Perimeter() { return 2 * (length + width); }
    }

    // Circle implementation
    class Circle : IShape
    {
        private double radius;
        public Circle(double radius) { this.radius = radius; }

        public double Area() { return Math.PI * radius * radius; }

        public double Perimeter() { return 2 * Math.PI * radius; }
    }

    // Triangle implementation
    class Triangle : IShape
    {
        private double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        public double Area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public double Perimeter() { return a + b + c; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of IShape references (Polymorphism)
            IShape[] shapes = new IShape[]
            {
            new square(5),
            new Rectangle(5, 10),
            new Circle(7),
            new Triangle(5, 6, 7)
            };

            // Loop through shapes and call methods dynamically
            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.GetType().Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}\n");
            }

            Console.ReadKey();
        }
    }
}
