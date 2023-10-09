using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBased_test2
{

    class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }



    class Program1
    {
        static void Main()
        {
            List<Products> products = new List<Products>();



            // Accept 10 products from the user
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");
                Console.Write("Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());



                Products product = new Products
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price
                };



                products.Add(product);
            }

            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            Console.WriteLine("\nSorted Products based on their Price: ");
            foreach (Products product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price:C}");
                Console.ReadLine();
            }
        }
    }
}