Console.Write("Enter a hexadecimal number: ");
string hexNumber = Console.ReadLine();

try
{
    int hexadecimal = Convert.ToInt32(hexNumber, 16);
    Console.WriteLine($"Hexadecimal Representation of {hexNumber} is {hexadecimal}");
}catch(FormatException) {
    Console.WriteLine("Invalid Hexadecimal Number");
}

Console.ReadKey();
