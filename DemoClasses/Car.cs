using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{   
    // Internal means it can ONLY BE ACCESSED from within the same class 
    internal class Car
    {   
        // member variable
        private string _model = "";
        private string _type = "";
        private string _brand = "";

        private string[] cars = ["Audi", "BMW", "Koenigsegg", "Pagani", "Mclaren", "Shelby", "Chevrolet", "Lambogini"];
        private string[] carType = ["Sedan", "Suv", "Supercar", "Hotrod"];


        public string Model
        {
            get
            {
                return _model;
            }
            set
            {   if (string.IsNullOrEmpty(_model))
                {
                    Console.WriteLine("You Have Entered an Invalid Model");
                }
                _model = value;
            }
        }
        public string Type
        {

            get
            {
                return _type;
            }
            set     // Modifying setter
            {   if(string.IsNullOrEmpty(_type) || carType.Contains(_type))
                {
                    Console.WriteLine("Please Enter a Car Type of Following -\"Sedan\", \"Suv\", \"Supercar\", \"Hotrod\" ");
                    _type = "Sedan";
                }else
                {
                    _type = value;
                }
                
            }
        }
        public string Brand
        {
            get
            {
                return _brand;
            }
            set  // Modifying Setter
            {
                if (string.IsNullOrEmpty(_brand) || cars.Contains(_brand))
                {
                    Console.WriteLine("Please Enter only the Cars of Following Choices -\"Audi\", \"BMW\", \"Koenigsegg\", \"Pagani\", \"Mclaren\", \"Shelby\", \"Chevrolet\", \"Lambogini\" ");
                    _brand = "BMW";
                }else
                {
                    _brand = value;
                }
                
            }

        }

        public Car(string model, string type, string brand)  // this is a Constructor
        {
            Model = model;
            Type = type;
            Brand = brand;

        }

       

        //member function
        public void displayModel()
        {
            Console.WriteLine($"The User drives a {Brand} car of {Type} of {Model} model");
        }
    }
}
