using System;

namespace CollectorOfGarbage
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Object created.");
        }

        ~MyClass() // Finalizer
        {
            Console.WriteLine("Object finalized (collected by GC).");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Garbage Collector Demo ===");

            CreateAndReleaseObject();

            // Force Garbage Collection
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Garbage Collection complete.");
            Console.ReadKey();
        }

        static void CreateAndReleaseObject()
        {
            MyClass obj = new MyClass();
            obj = null; // Eligible for GC
        }
    }
}
