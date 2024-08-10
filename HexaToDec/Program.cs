// Prompt the user to enter a decimal number
Console.Write("Enter a decimal number: ");
int decimalNumber;

while(!int.TryParse(Console.ReadLine(), out decimalNumber) || decimalNumber < 0)
{
    Console.WriteLine("Invalid Decimal Number");
}

// Convert the decimal number to a hexadecimal number
string hexNumber = ConvertDecimalToHex(decimalNumber);

// Display the result
Console.WriteLine("Hexadecimal representation: " + hexNumber);

static string ConvertDecimalToHex(int decimalNumber)
{
    return decimalNumber.ToString("X");
}

Console.ReadKey();
