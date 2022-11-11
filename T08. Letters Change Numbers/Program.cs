using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace T08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // step 1 reading the input 
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); // => [ A12b, s17G]
            double sum = 0;
            // step 2 foreach through all the ruslts in the array and do mathematical adding, substracting, dividing and mulitplying

            // step 3 priting the reuslt on the console

            foreach (string item in input)
            {
                char firstLetter = item[0]; // A
                char lastLetter = item[^1]; // this is the same as item.length - 1 ==> b

                string numAsAString = item[1..^1]; // this will give us everything that's between 0 and the last index; => 12
                double numFromString = double.Parse(numAsAString); //12
                if (char.IsUpper(firstLetter))
                {
                    int postionOfTheLetter = firstLetter - 64;
                    numFromString /= postionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    numFromString *= positionOfTheLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int positionOfTheLetter = lastLetter - 64;
                    numFromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numFromString += positionOfTheLetter;
                }
                sum += numFromString; 
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
