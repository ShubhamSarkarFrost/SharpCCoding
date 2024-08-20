Console.WriteLine("The Following Program calculates the O's and 1's for any decimal number entered");
int number = int.Parse(Console.ReadLine());

(int countofzeros, int countofones) = CountOnesAndZeros(number);

Console.WriteLine($"The Number of Zeros are: {countofzeros}");
Console.WriteLine($"The Number of Ones are: {countofones}");




static (int ones, int zeros) CountOnesAndZeros(int number)
{
    // Convert the number to its binary representation as a string
    string binaryString = Convert.ToString(number, 2);

    // Initialize counters for ones and zeros
    int countOnes = 0;
    int countZeros = 0;

    // Iterate through each character in the binary string
    foreach (char c in binaryString)
    {
        if (c == '1')
        {
            countOnes++;
        }
        else if (c == '0')
        {
            countZeros++;
        }
    }

    // Return the counts as a tuple
    return (countOnes, countZeros);
}

Console.ReadKey();