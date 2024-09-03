using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyAndReadOnly
{
    internal class car
    {
        public static int NumberOfCars = 0;

        // member variable
        // private hides the variable from other classes
        // Backing Field of the Model property
        //private string _model = "";

        private string _brand = "";

        //private bool _isLuxury;

        // Property
        // With lambda expression
        //public string Model { get => _model; set => _model = value; }

        public string Model { get; set; }


        public string Brand
        {

            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
            }

        }

        public bool IsLuxury { get; set; }

        //public bool IsLuxury { get => _isLuxury; 
        //    set => _isLuxury = value; }

        // Custom Constructor
        public car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;

            Model = model;
            Brand = brand;
            Console.WriteLine($"A {Brand} of the" +
                $" model {Model} has been created");
            IsLuxury = isLuxury;
        }

        public car()
        {
            NumberOfCars++;
        }

        private void Drive()
        {
            Console.WriteLine($"I'm a {Model} and I'm driving");
        }
    }
}
