
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession;

namespace ConcessionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcessionCalculator calculator = new ConcessionCalculator();
            Console.WriteLine("Welcome to Ticket Booking Club");
            Console.Write("Enter Your Name: ");

            calculator.Name = Console.ReadLine();

            Console.Write("Enter Your Age: ");

            calculator.Age = Convert.ToInt32(Console.ReadLine());

            string result = calculator.CalculateConcession(calculator.Age);

            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
}
       
    

