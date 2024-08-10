// Sample string
string input = "Hello, World!";

// Index of the character to remove
int indexToRemove = 7;

// Call the method to remove the character
string result = RemoveCharacterAtIndex(input, indexToRemove);

// Display the result
Console.WriteLine("Original string: " + input);
Console.WriteLine("Modified string: " + result);


static string RemoveCharacterAtIndex(string input, int indexToRemove)
{
    if(indexToRemove < 0 || indexToRemove > input.Length)
    {
        throw new ArgumentOutOfRangeException("index", "Index is out of range.");
    }

    return input.Remove(indexToRemove);
}

Console.ReadKey();
