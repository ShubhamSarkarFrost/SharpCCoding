static int Compare(string str1, string str2)
{
    int i = 0;

    // Compare each character of both strings
    while (i< str1.Length && i <str2.Length)
    {

        if (str1[i] != str2[i])
        {
            return str1[i] - str2[i];
        }
        i++;
    }

    // If we reached the end of one string, compare lengths
    if (str1.Length != str2.Length)
    {

        return str1.Length - str2.Length;   
    }

    return 0;
}

Console.WriteLine("Enter the first string:");
string str1 = Console.ReadLine();

Console.WriteLine("Enter the second string:");
string str2 = Console.ReadLine();

int result = Compare(str1, str2);

if (result == 0)
{
    Console.WriteLine("The strings are equal.");
}
else if (result < 0)
{
    Console.WriteLine("The first string is less than the second string.");
}
else
{
    Console.WriteLine("The first string is greater than the second string.");
}
