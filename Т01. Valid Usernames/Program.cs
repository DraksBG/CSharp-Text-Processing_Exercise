using System;

namespace Т01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read the input from the console
            string[] usernames = Console.ReadLine().Split(", ");
            // interate throug all the usernames 
            foreach (string  currName in usernames)
            {
                // sh //pesho
                if (currName.Length > 3 && currName.Length <= 16)
                {
                    // check if the userName is valid 
                    bool isUsarnameValid = true;    
                    foreach (char currChar in currName) // => charrArray = [s, h]
                        // => [p, e, s, h, o]
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            isUsarnameValid = false;
                            break;
                        }
                    }
                    if (isUsarnameValid)
                    {
                        Console.WriteLine(currName); // pesho
                    }
                }
            }
        }
    }
}
