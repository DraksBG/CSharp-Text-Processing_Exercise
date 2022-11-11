using System;
using System.Text;

namespace T05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // 23
            int mulitplier = int.Parse(Console.ReadLine()); // 2
            var sb = new StringBuilder(); // create empty string builder which will give us a methods that we can use to build our string 
            int reminder = 0;
            // safeguard if user tries sometight funnu or forbinden
            if (mulitplier == 0 || input == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--) // 23 ==> 32
            {
                int currDigit = int.Parse(input[i].ToString()); // 3
                int product = currDigit * mulitplier + reminder;
                int result = product % 10; // 32 / 10 => 2
                reminder = product / 10;
                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
