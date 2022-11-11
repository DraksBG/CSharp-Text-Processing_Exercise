using System;

namespace T06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // step 1 = Reding the input from the console
            string text = Console.ReadLine();
            // Step 2 => text = aaaabbbccc => previousCahr = text[0]
            char previousChar = text[0];   // 'a'
            Console.Write(previousChar);
            // step 3 iterate throght the text straing 1 index
            for (int i = 1; i < text.Length; i++)
            {
                // Step 4 taking the currentChar and miking check with the previous
                char currentChar = text[i];
                if (previousChar != currentChar) // a != b then previusChar = b
                {
                    previousChar = currentChar;
                    Console.Write(previousChar); // 'ab'
                }
            }
        }
    }
}
