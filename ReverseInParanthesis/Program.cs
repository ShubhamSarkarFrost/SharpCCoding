using System.Text;

namespace ReverseInParanthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example input string
            string input = "(abc(de(fg)h)ij)kl";

            // Call the method to reverse the strings within parentheses
            string result = ReverseParentheses(input);

            // Print the result
            Console.WriteLine("Output string:");
            Console.WriteLine(result);
        }

        static string ReverseParentheses(string s)
        {
            Stack<StringBuilder> stack = new Stack<StringBuilder>();
            StringBuilder current = new StringBuilder();

            foreach (char c in s)
            {
                if (c == '(')
                {
                    // Push the current StringBuilder onto the stack and start a new one
                    stack.Push(current);
                    current = new StringBuilder();
                }
                else if (c == ')')
                {
                    // Reverse the current StringBuilder
                    current = new StringBuilder(current.ToString().Reverse().ToArray());

                    // Pop from the stack and append the reversed string to the previous content
                    StringBuilder previous = stack.Pop();
                    previous.Append(current);
                    current = previous;
                }
                else
                {
                    // Append the character to the current StringBuilder
                    current.Append(c);
                }
            }

            return current.ToString();
        }

    }
    }
