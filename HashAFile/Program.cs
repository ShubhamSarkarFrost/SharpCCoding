using System;
using System.Security.Cryptography;
using System.Text;

namespace HashAFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to Hash");
            string word = Console.ReadLine();

            string hashWord = Compute256HashWord(word);

            Console.WriteLine($"The Hashed word of ${word} is ${hashWord}");
            Console.ReadKey();
        }

        static string Compute256HashWord(string word)
        {
            //Create a sha256Hash instance
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(word));

                StringBuilder builder = new StringBuilder();
                for(int i = 0; i< bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }
    }
}
