using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Customer

    {

        private int customerID;

        private string name;

        private int age;

        private string phone;

        private string city;

        public Customer()

        {

            Console.WriteLine("No-argument constructor called.");

        }

        // Constructor with all information

        public Customer(int customerID, string name, int age, string phone, string city)

        {

          

            this.customerID = customerID;

            this.name = name;

            this.age = age;

            this.phone = phone;

            this.city = city;

        }

        public void DisplayCustomer()

        {

            Console.WriteLine("Customer ID: {0}", customerID);

            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("Age: {0}", age);

            Console.WriteLine("Phone: {0}", phone);

            Console.WriteLine("City: {0}", city);

        }

        

    }

    class Program3

    {

        static void Main(string[] args)

        {
            Customer customer1 = new Customer();

            Customer customer2 = new Customer(1, "SHubhangi Pandey", 30, "123-456-7890", "Uttar Pradesh");


            customer2.DisplayCustomer();

            Console.ReadKey();

        }

    }

}

