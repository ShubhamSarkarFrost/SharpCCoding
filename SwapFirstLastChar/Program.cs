Console.WriteLine("Please Enter the Word to Interchnage the Character's");
string word = Console.ReadLine();



if(word.Length > 0)
{
    word = word.Substring(word.Length - 1) + word.Substring(1, word.Length - 2) + word.Substring(0, 1);
    Console.WriteLine(word);
}
else
{
    Console.WriteLine("Please Enter a word with one or more character");
}

Console.ReadKey();


