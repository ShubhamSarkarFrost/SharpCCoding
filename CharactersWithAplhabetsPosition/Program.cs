Console.Write("Enter the string: ");
string input = Console.ReadLine();

foreach(char c in input)
{

    char lowerCase = char.ToLower(c);

    int position = lowerCase - 'a' + 1;

    if(position >= 1 && position <= 26)
    {
        Console.WriteLine($"The Position of {c} with respect to English Alphabet is {position}");
    }else
    {
        Console.WriteLine($"The Character is Not an Alphabet");
    }
}
