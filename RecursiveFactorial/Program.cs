Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Factorial of {number} is: {factorial}");


static int Factorial(int n)
{
    // Base case: factorial of 0 or 1 is 1
    if (n == 0 || n == 1)
    {
        return 1;
    }

    // Recursive case: n * factorial of (n-1)
    return n * Factorial(n - 1);
}
