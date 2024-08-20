using System.Text;

Console.WriteLine("Please Enter the Sentence in which Vowels need to be removed");
string sentence = Console.ReadLine();

Console.WriteLine($"The Sentence after removing vowels is {removeVowels(sentence)}");



static string removeVowels( string sentence)
{
    string checkVowels = "aeiouAEIOU";
    StringBuilder result = new StringBuilder();

    foreach(char c in sentence)
    {
        if (!checkVowels.Contains(c))
        {

            result.Append(c);
        }
    }

    return result.ToString();
}

Console.ReadKey();