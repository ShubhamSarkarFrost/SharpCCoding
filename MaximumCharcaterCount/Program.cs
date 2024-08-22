Console.Write("Enter the string: ");
string input = Console.ReadLine();

string[] words = input.Split(' ');


foreach(string word in words)
{
    char maxChar = ' ';
    int maxFrequency = 0;
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    foreach(char c in word)
    {

        if (charCount.ContainsKey(c))
        {
            charCount[c]++;
        }else
        {
            charCount[c] = 1;
        }

        if (charCount[c] > maxFrequency)
        {
            maxFrequency = charCount[c];
            maxChar = c; 
        }
    }

    Console.WriteLine($"In the word '{word}', the character '{maxChar}' has the highest frequency of {maxFrequency}.");

}


