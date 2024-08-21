
Console.WriteLine("Please Enter a string with alphabets , special characters & digits");
string mixed_sen = Console.ReadLine();

(int countalphabets, int countdigits, int specialcharcaters) = countCharacters(mixed_sen);


Console.WriteLine($"The Number of Alphabets are : {countalphabets}");
Console.WriteLine($"The Number of Digits are : {countdigits}");
Console.WriteLine($"The Number of Special Characters are : {specialcharcaters}");




static (int countalphabets, int countdigits, int specialcharcaters) countCharacters(string mixed_sen)
{
    int countdig = 0;
    int countalpha = 0;
    int countspecial = 0;

   foreach(char c in mixed_sen)
    {

        if(c >='0' && c <= '9')
        {
            countdig++;
        }
        else if( (c >= 'a' && c <='z') || (c >= 'A' && c <= 'Z'))
        {
            countalpha++;
        }else
        {
            countspecial++;
        }
    }
    return (countalpha, countdig, countspecial);
}

Console.ReadKey();