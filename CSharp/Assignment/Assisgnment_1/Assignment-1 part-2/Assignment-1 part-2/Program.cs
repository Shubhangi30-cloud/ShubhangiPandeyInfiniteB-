using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first  number");
            int firstInt = Convert.ToInt32(Console.ReadLine());

            if (firstInt >= 0)
            {
                Console.WriteLine("Number is positive");
                Console.ReadKey();      
                    }
            else
            {
                Console.WriteLine("Number is negative");
                Console.ReadKey();
            }

        }
    }
}
