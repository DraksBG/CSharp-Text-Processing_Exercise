using System;
using System.Text;

namespace T04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // Programming is cool!
            var sb = new StringBuilder();
            foreach (char currCahr in input)
            {
                int currPositon = currCahr; // currChar = "P" in int => 80
                currPositon += 3;
                sb.Append((char)currPositon); // 83 int into char => 'S'
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
