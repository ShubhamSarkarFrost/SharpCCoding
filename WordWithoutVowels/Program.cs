Console.WriteLine("Please Enter a Word to Remove all the Vowels from !!");
string word = Console.ReadLine();
word = word.ToLower();
string newWord = "";

char[] letters = word.ToCharArray();

foreach(char letter in letters)
{
    if (letter.Equals('a') || letter.Equals('e') || letter.Equals("i") || letter.Equals("o") || letter.Equals("u"))
    {
        continue;
    }
    else
    {
        newWord += letter;
    }
}

Console.WriteLine(newWord);
Console.ReadKey();
