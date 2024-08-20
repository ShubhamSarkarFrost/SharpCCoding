Console.WriteLine("Please Enter the Sentence we want to sort");
string sen = Console.ReadLine();

string sorted_sen = sort_sentence_ascending(sen);
Console.WriteLine($"The Sentence sorted in acending order is : {sorted_sen}");


static string sort_sentence_ascending(string sentence)
{
   string[] words = sentence.Split(' ');

    for(int i = 0; i< words.Length - 1; i++)
    {
        for(int j=0; j<words.Length - 1 - i; j++)
        {
            if (string.Compare(words[j], words[j+1]) > 0)
            {
                string temp = words[j];
                words[j] = words[j + 1];
                words[j + 1] = temp;
            }


        }

    }

    return string.Join(" ", words);
}

Console.ReadKey();
