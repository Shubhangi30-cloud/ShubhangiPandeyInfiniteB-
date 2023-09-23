using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class part_3
    {
     static void Main(String[] args)
        {
            Console.WriteLine("enter first word");
            String wordOne = Console.ReadLine();
            Console.WriteLine("enter second word");
            String wordTwo = Console.ReadLine();
            if (wordOne == wordTwo)
            {
                Console.WriteLine("the given words are equal");
            }
            else
            {
                Console.WriteLine("the given words are not equal.");
            }
            Console.ReadLine();
        }
    }
}