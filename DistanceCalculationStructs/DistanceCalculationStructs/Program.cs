namespace DistanceCalculationStructs
{

    struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point p)
        {
            double deltaX = p.X - this.X;
            double deltaY = p.Y - this.Y;
            return deltaX * deltaX + deltaY * deltaY;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for coordinates of the first point
            Console.Write("Enter X coordinate for Point 1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Y coordinate for Point 1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            // Prompt user for coordinates of the second point
            Console.Write("Enter X coordinate for Point 2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Y coordinate for Point 2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Create Point instances
            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);

            // Calculate and display the distance
            double distance = point1.DistanceTo(point2);
            Console.WriteLine($"\nDistance between the two points: {distance:F4}");
            Console.ReadKey();
        }
    }
}
