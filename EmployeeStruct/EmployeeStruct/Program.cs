namespace EmployeeStruct
{
    public struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Parameterized constructor
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine($"Employee Id: {Id}, Name: {Name}");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            // Calling parameterized constructor
            Employee emp = new Employee(101, "Shubham");

            // Printing values
            emp.Print();
            Console.ReadKey();
        }
    }
}
