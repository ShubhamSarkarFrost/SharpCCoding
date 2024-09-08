using System.Text;
using System.Text.RegularExpressions;

namespace ExtractWordsThroughRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Sentence from which the pattern type words has to be extracted!");
            string sentence = Console.ReadLine();
            string patterned_sentence = ExtractPatternedWords(sentence);
            Console.WriteLine($"Extracted patterened sentence is ${patterned_sentence}");
            Console.ReadKey();
        }

        static string ExtractPatternedWords(string sen)
        {
            string[] words = sen.Split(' ');
            StringBuilder builder = new StringBuilder();

            string pattern = @"^[a-zA-Z0-9]+$";

            foreach(string word in words)
            {
                if (Regex.IsMatch(word, pattern)){
                    builder.Append(word).Append(' ');
                }
            }

            return builder.ToString().Trim();
        }

    }
}
