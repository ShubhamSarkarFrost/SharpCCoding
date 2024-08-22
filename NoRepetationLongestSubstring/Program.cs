// Input the string
Console.Write("Enter the string: ");
string input = Console.ReadLine();

int maxLength = LengthOfLongestSubstring(input);

Console.WriteLine("The length of the longest substring without repeating characters is: " + maxLength);


static int LengthOfLongestSubstring(string input)
{
    int[] lastIndex = new int[256];
    for (int i = 0; i < lastIndex.Length; i++)
    {
        lastIndex[i] = -1;
    }

    int maxLength = 0;
    int start = 0;

    for (int i = 0; i < input.Length; i++)
    {
        char currentChar = input[i];

        if (lastIndex[currentChar] > start)
        {
            start = lastIndex[currentChar] + 1;
        }

        // Update the last index of the current character
        lastIndex[currentChar] = i;

        // Calculate the current length and update maxLength if needed
        maxLength = Math.Max(maxLength, i - start + 1);
    }
    return maxLength;
}

Console.ReadKey();