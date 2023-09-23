using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            int length = word.Length;
            Console.WriteLine("Length of the word is:" + length);
            Console.ReadLine();
        }
    }
}
