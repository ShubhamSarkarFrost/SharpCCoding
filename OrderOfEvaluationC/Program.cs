class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = 30;

        // Order of evaluation
        int result = a + b * c; // Multiplication is performed first, then addition
        Console.WriteLine("Result of a + b * c: " + result);

        // Using parentheses to change the order
        result = (a + b) * c; // Addition is performed first, then multiplication
        Console.WriteLine("Result of (a + b) * c: " + result);

        // Another example with different operators
        int x = 5;
        int y = 10;
        int z = 15;

        int result2 = x + y - z / x; // Division is performed first, then addition, then subtraction
        Console.WriteLine("Result of x + y - z / x: " + result2);

        // Using parentheses to change the order
        result2 = (x + y - z) / x; // Addition and subtraction are performed first, then division
        Console.WriteLine("Result of (x + y - z) / x: " + result2);

        // Demonstrating short-circuit evaluation with logical operators
        bool cond1 = true;
        bool cond2 = false;

        bool result3 = cond1 || Method1(); // Method1() is not called because cond1 is true
        Console.WriteLine("Result of cond1 || Method1(): " + result3);

        bool result4 = cond2 && Method1(); // Method1() is not called because cond2 is false
        Console.WriteLine("Result of cond2 && Method1(): " + result4);

        Console.ReadKey();
    }

    static bool Method1()
    {
        Console.WriteLine("Method1() was called.");
        return true;
    }
}