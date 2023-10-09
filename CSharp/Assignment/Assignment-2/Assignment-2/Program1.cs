using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the array");
            int[] data = new int[5];
            for (int i = 0; i < 5; i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int i in data)
            {
                sum += i;


            }
            Console.WriteLine($" maximum number is : {data.Max()}");
            Console.WriteLine("minimum number is " + data.Min());
            Console.WriteLine(sum / data.Length);
            Console.ReadLine();
        }
    }
    class secondProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the array");
            int[] marks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int i in marks)
            {
                sum += i;
            }
            Console.WriteLine(sum / marks.Length);
            Console.WriteLine($" maximum number is : {marks.Max()}");
            Console.WriteLine("minimum number is " + marks.Min());
            Array.Sort(marks);
            Console.WriteLine("the array in ascending order: ");
            foreach (int x in marks)
            {
                Console.WriteLine(x);
            }
            Array.Reverse(marks);
            Console.WriteLine("the array in descending order: ");
            foreach (int x in marks)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }

}
