using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class part2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            string result = "";
            char[] c = word.ToCharArray();

            for(int i = word.Length-1; i >=0; i--)
            {
                result += c[i];
            }



           
            Console.WriteLine("Reverse of the word is:" + result);
            Console.ReadLine();
        }
    }
}

