using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Program1

    {

        public static void Main(string[] args)

        {

            Console.WriteLine("Enter a string:");

            string inputString = Console.ReadLine();

            Console.WriteLine("Enter a letter to count:");

            char letter = char.Parse(Console.ReadLine());

            int count = CountOccurrences(inputString, letter);

            Console.WriteLine($"The letter '{letter}' appears {count} times in the string.");
            Console.ReadLine();
        }

        public static int CountOccurrences(string inputString, char letter)

        {

            int count = 0;

            foreach (char c in inputString)

            {

                if (char.ToUpper(c) == char.ToUpper(letter))

                {

                    count++;

                }

            }

            return count;

        }

    }
}
