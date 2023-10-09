using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest_4
{
    class Program
    {
        static void Main()
        {
            string filePath = "C:\\Users\\shubhangp\\desktop\\sample.txt";
            Console.WriteLine("Enter text to append to the file:");
            string textToAppend = Console.ReadLine();

            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))

                {
                    writer.WriteLine(textToAppend);
                }
                Console.WriteLine("Text appended to the file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadLine();
        }
    }

}