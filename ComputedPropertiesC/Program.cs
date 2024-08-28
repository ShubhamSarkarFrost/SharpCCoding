namespace ComputedPropertiesC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputedClass cs = new ComputedClass(value1: 12, value2: 13);
            Console.WriteLine(cs.ComputedProperty);
        }
    }
}
