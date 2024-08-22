Console.Write("Enter a string: ");
string input = Console.ReadLine();

// Get the longest palindromic substring
string longestPalindrome = LongestPalindromicSubstring(input);

// Output the result
Console.WriteLine($"The longest palindromic substring is: \"{longestPalindrome}\"");


static string LongestPalindromicSubstring(string s)
{
    if(string.IsNullOrEmpty(s))
       return "";

    int maxLength = 1;
    int start = 0;

    int length = s.Length;

    //Create a 2D to store the palindromic number 
    bool[,] palindromic = new bool[length, length];

    //if every chracter in array is palindromic 
    for(int i = 0; i<length; i++)
    {
        palindromic[i, i] = true; 
    }

    //check if 2 charcaters are palindromic 
    for(int i = 0; i<length; i++)
    {
        if (s[i] == s[i + 1])
        {
            palindromic[i, i + 1] = true;
            start = i;
            maxLength = 2;
        }
    }

    // Check for palindromes longer than two characters
    for(int k = 3; k<=length; k++)
    {
        for(int i = 0; i< length - k + 1; k++)
        {
            int j = i + k - 1;

            if (s[i] == s[j] && palindromic[i+1, j - 1])
            {
                palindromic[i, j] = true;

                if (k > maxLength)
                {
                    start = i;
                    maxLength = k;
                }
            }
        }
    }
    return s.Substring(start, maxLength);
}
