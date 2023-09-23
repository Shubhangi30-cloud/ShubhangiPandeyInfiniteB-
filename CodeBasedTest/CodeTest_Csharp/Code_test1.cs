using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest_Csharp
{
    class Code_test1
    {
         static void Main()
            Console.WriteLine("Enter the string");
            string inputstring = Console.ReadLine();



            Console.WriteLine("Enter the position to remove (0-indexed ):");
            int position = int.Parse(Console.ReadLine());



            if (position >= 0 && position < inputstring.Length) 
            {
                string modifiedstring = inputstring.Remove(position, 1);
                Console.WriteLine("");
                
            }
            else
            {
                Console.WriteLine("Invalid position. Please enter a valid position in the range 0 to " + (inputstring.Length - 1));
            }
        
    }
}
