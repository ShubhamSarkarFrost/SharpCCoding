Console.WriteLine("Armstrong numbers between 1 and 1000 are:");

for (int number = 1; number <= 1000; number++)
{
    int sum = 0;
    int temp = number;
    int digits = 0;

    // Calculate number of digits
    while (temp > 0)
    {
        digits++;
        temp /= 10;
    }

    temp = number;

    // Calculate the sum of the digits raised to the power of the number of digits
    while (temp > 0)
    {
        int digit = temp % 10;
        sum += (int)Math.Pow(digit, digits);
        temp /= 10;
    }

    // Check if the sum is equal to the original number
    if (sum == number)
    {
        Console.WriteLine(number);
    }
}

Console.ReadKey();

