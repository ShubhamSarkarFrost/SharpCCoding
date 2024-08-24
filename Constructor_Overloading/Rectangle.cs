using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    internal class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }
        /* This is the Way we can Overload the Constructor */
        // Default constructor (no parameters)
        public Rectangle()
        {
            Length = 1;  // Default length
            Width = 1;   // Default width
        }

        // Constructor with one parameter (square case)
        public Rectangle(int side)
        {
            Length = side;
            Width = side;
        }

        // Constructor with two parameters
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        // Method to calculate area
        public int GetArea()
        {
            return Length * Width;
        }
    }
}
