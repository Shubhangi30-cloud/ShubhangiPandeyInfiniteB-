﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Program

    {

        public static void Main(string[] args)

        {

            Console.WriteLine("Enter your first name:");

            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");

            string lastName = Console.ReadLine();

            Display(firstName, lastName);

        }

        public static void Display(string firstName, string lastName)

        {

            Console.WriteLine(firstName.ToUpper());

            Console.WriteLine(lastName.ToUpper());
            Console.ReadLine();

        }


    }
}
