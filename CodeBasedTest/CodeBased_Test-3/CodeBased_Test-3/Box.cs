using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBased_Test_3
{
    class Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Box Add(Box box2)
        {
            Box result = new Box();
            result.Length = this.Length + box2.Length;
            result.Breadth = this.Breadth + box2.Breadth;
            return result;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
        class Test
        {
            static void Main()
            {
                Box box1 = new Box { Length = 5, Breadth = 3 };
                Box box2 = new Box { Length = 2, Breadth = 6 };

                Box box3 = box1.Add(box2);

                Console.WriteLine("Details of box3");
                box3.DisplayDetails();
                Console.Read();
            }
        }
    }
}
