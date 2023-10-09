using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest_4
{
    public delegate int CalculatorDelegate(int num1, int num2);



    class Calculator

    {

        static int Add(int num1, int num2)

        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)

        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)

        {
            return num1 * num2;
        }

        static void Main()

        {
            Console.WriteLine("Enter two numbers:");

            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = Convert.ToInt32(Console.ReadLine());



            CalculatorDelegate addDelegate = new CalculatorDelegate(Add);

            CalculatorDelegate subtractDelegate = new CalculatorDelegate(Subtract);

            CalculatorDelegate multiplyDelegate = new CalculatorDelegate(Multiply);



            int resultAddition = addDelegate(num1, num2);

            int resultSubtraction = subtractDelegate(num1, num2);

            int resultMultiplication = multiplyDelegate(num1, num2);


            Console.WriteLine($"Addition: {resultAddition}");
            Console.WriteLine($"Subtraction: {resultSubtraction}");
            Console.WriteLine($"Multiplication: {resultMultiplication}");
            Console.ReadLine();
        }
        

    }
}
