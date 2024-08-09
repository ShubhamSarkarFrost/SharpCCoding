int num;

Console.WriteLine("Enter a decimal number: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("The binary equivalent of num is :");
binaryconversion(num);
Console.ReadLine();


static int binaryconversion(int num)
{
    int bin = 0;
    if (num != 0)
    {
        bin = (num % 2) * 10 + binaryconversion(num / 2);
        Console.Write(bin);
        return 0;
    }
    else
    {
        return 0;
    }
}

Console.ReadKey();


