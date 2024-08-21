
Console.WriteLine("Please Enter the Word you want to Swap");
string word = Console.ReadLine();

string swappedword = WordsSwap(word);
Console.WriteLine($"The Swapped Word is {swappedword}");

string WordsSwap(string? word)
{
    if (word.Length > 1)
    {

        return word.Substring(0, word.Length - 2) + word[word.Length - 1] + word[word.Length - 2];
    }else
    {
        return word;
    }
}

Console.ReadKey();
