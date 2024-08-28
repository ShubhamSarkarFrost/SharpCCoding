namespace ReplaceaWordWithoutReplaceMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Sentence");
            String sentence = Console.ReadLine();
            Console.WriteLine("Enter the Word to Replace");
            String word = Console.ReadLine();
            Console.WriteLine("Enter the Word to Replace With");
            String replaceWord = Console.ReadLine();

            String UpdatedSentence = ReplaceWordWithWord(sentence, word, replaceWord);
            Console.WriteLine($"The Updated sentence is : "+UpdatedSentence);
        }

        static string ReplaceWordWithWord(String sentence, String word, String replaceWord)
        {

            string[] words = sentence.Split(' ');
            string newSen = "";

            for(int i = 0; i< words.Length; i++)
            {
                if (words[i].Contains(word))
                {
                    if (words[i].EndsWith("."))
                    {
                        newSen += words[i] + ".";
                    }
                    else if (words[i].EndsWith(","))
                    {
                        newSen += words[i] + ",";
                    }
                    else
                    {
                        newSen += words[i];
                     }

                    // add a space before last word
                    if(i < words.Length - 1)
                    {
                        newSen += " ";
                    }
                }

            }
            return newSen;

            
        }
    }
}
