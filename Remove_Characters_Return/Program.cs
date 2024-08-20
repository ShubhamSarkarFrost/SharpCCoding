
Console.WriteLine("Please Enter the Sentence");
string sentence = Console.ReadLine();
Console.WriteLine("Please Enter the Word to Check");
string Searchword = Console.ReadLine();

string result = RemoveWordAtPosition(sentence, Searchword);

// Print the result
Console.WriteLine(result);



string RemoveWordAtPosition(string? sentence, string? Searchword)
{
    string[] words = sentence.Split(' ');
    string updatesen = "";
    
    foreach(string word in words)
    {
        if (!word.Equals(Searchword))
        {
            updatesen = updatesen +" "+word;
        }else
        {
            continue;
        }
    }

    return updatesen.Trim();
}

Console.ReadKey();





