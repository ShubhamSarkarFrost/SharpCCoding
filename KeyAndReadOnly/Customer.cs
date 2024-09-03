using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyAndReadOnly
{
    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;

        // Read-only instance field initialized from the constructor
        private readonly int _id;

        //readonly ID
        public int Id
        {

            get
            {
                return _id;
            }
        }


        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            _id = nextId++;
            Name = "New Customer";
            Address = "Unknown";
            ContactNumber = "None";
        }




        // Default/Optional parameters address and contactNumber 
        // Custom Constructor
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;

        }

        // Default Paramter contactNumber
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;

        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer: Name is {Name} and Id is {_id}");
        }


        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I'm doing some customer stuff");
        }


    }
}
