
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int sum = SumOfDigits(number);
Console.WriteLine("Sum of the digits: " + sum);

static int SumOfDigits(int n)
{
    if (n == 0)
    {
        return 0;
    }


    return (n % 10) + SumOfDigits(n / 10);


}

Console.ReadKey();