using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment
{
    class one
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Enter the first  number");
                int firstInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second  number");
                int secondInt = Convert.ToInt32(Console.ReadLine());

                if (firstInt == secondInt)
                {
                    Console.WriteLine("two numbwes are equal");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Two numbers are not equal");
                    Console.ReadKey();
                }

            } }

       



            }
    class two
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first  number");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second  number");
            int secondInt = Convert.ToInt32(Console.ReadLine());
            if (firstInt >= 0)
            {
                Console.WriteLine("Number is positive");

            }
            else
            {
                Console.WriteLine("Number is negative");

            }
            Console.ReadKey();
        }
    }

    class third
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondInt = Convert.ToInt32(Console.ReadLine());

            int finalSum = sum(firstInt, secondInt);
            int finalprod = prod(firstInt, secondInt);
            int finaldiv = div(firstInt, secondInt);
            int finalsubs = subs(firstInt, secondInt);
            Console.WriteLine($"final sum is : {finalSum}");
            Console.WriteLine($"final prod is : {finalprod}");
            Console.WriteLine($"final div is: {finaldiv}");
            Console.WriteLine($"final subs is: {finalsubs}");
            Console.ReadKey();


        }

        static int sum(int a, int b)
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
        
