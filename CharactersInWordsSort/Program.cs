// Bubble Sort Algorithim 
Console.WriteLine("Please Enter the word to Sort");
string word = Console.ReadLine();

Console.WriteLine($"Sorted Word is {SortedWord(word)}");

static string SortedWord(string word)
{
    // Convert the word to a character array
    char[] charArray = word.ToCharArray();
    int length = charArray.Length;

    for(int i =0; i<length -1; i++)
    {
        for(int j = 0; j <length - i- 1; j++)
        {
            if (charArray[j] > charArray[j + 1])
            {
                char temp = charArray[j];
                charArray[j] = charArray[j + 1];
                charArray[j + 1] = temp;
            }
        }
    }

    string sortedWords = new string(charArray);

    return sortedWords;


}

Console.ReadKey();