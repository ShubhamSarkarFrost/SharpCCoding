Console.WriteLine("Amicable numbers between 1 and 10000 are:");

for (int i = 1; i <= 10000; i++)
{
    int sum1 = SumOfDivisors(i);
    if (sum1 > i && sum1 <= 10000) // Prevents printing duplicates and checks within range
    {
        int sum2 = SumOfDivisors(sum1);

        if (sum2 == i)
        {
            Console.WriteLine($"({i}, {sum1})");
        }
    }
}

static int SumOfDivisors(int num)
{
    int sum = 0;

    for (int i = 1; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            sum += i;
        }
    }

    return sum;
}