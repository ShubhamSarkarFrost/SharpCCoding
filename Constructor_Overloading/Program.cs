using System.Drawing;

namespace Constructor_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the default constructor
            Rectangle rect1 = new Rectangle();
            Console.WriteLine($"Rectangle 1: Length = {rect1.Length}, Width = {rect1.Width}, Area = {rect1.GetArea()}");

            // Using the constructor with one parameter (square)
            Rectangle rect2 = new Rectangle(5);
            Console.WriteLine($"Rectangle 2: Length = {rect2.Length}, Width = {rect2.Width}, Area = {rect2.GetArea()}");

            // Using the constructor with two parameters
            Rectangle rect3 = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle 3: Length = {rect3.Length}, Width = {rect3.Width}, Area = {rect3.GetArea()}");

            Console.ReadKey();
        }
    }
}
