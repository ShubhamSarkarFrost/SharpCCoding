
string sentence = "Hello, this is a sample sentence";
int n = 3; // Number of times to repeat the last word

// Call the method to repeat the last word n times
string modifiedSentence = RepeatLastWord(sentence, n);



// Print the modified sentence
Console.WriteLine(modifiedSentence);



string RepeatLastWord(string sentence, int n)
{
    string[] word = sentence.Split(' ');

    string lastword = word[word.Length - 1];

    // Create a new string to hold the original sentence and the repeated last word
    string result = sentence;

    // Repeat the last word n times
    for (int i = 0; i < n; i++)
    {
        result += " " + lastword;
    }
    return result;
}

Console.ReadKey();