using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondInt = Convert.ToInt32(Console.ReadLine());

            int finalSum = sum(firstInt, secondInt);
            int finalprod = prod(firstInt, secondInt);
            int finaldiv= div(firstInt, secondInt);
            int finalsubs = subs(firstInt, secondInt);
            Console.WriteLine( $"final sum is : {finalSum}");
            Console.WriteLine($"final prod is : {finalprod}");
            Console.WriteLine($"final div is: {finaldiv}");
            Console.WriteLine($"final subs is: {finalsubs}");
            Console.ReadKey();


        }

         static  int sum(int a,int b)
        {
            return a + b;
        }
       static int prod(int a, int b)
        {
            return a * b;
        }
       static int div(int a, int b)
        {
            return a / b;
        }
       static int subs(int a, int b)
        {
            return a - b;

        }


    }
    }

