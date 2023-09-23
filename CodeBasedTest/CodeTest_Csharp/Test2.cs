using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest_Csharp
{
    class Test2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication Table of" + number + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + "x" + i + "=" + (number * i));
                Console.ReadLine();
            }
        }
    }
}
