using System.Text.RegularExpressions;

Console.Write("Enter a string: ");
string input = Console.ReadLine();

// Remove all non-letter characters
string result = RemoveNonLetterCharacters(input);

// Display the result
Console.WriteLine("String with only letters: " + result);


static string RemoveNonLetterCharacters(string input)
{
    return Regex.Replace(input, "[^a-zA-Z]", "");
}
