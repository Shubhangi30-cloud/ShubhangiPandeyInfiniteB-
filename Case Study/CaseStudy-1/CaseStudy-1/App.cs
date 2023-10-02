using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_1
{
    public class App

    {
        public static void Main()
        {

            // Scenario 1

             void Scenario1()

            {

                Info info = new Info();



                Student student1 = new Student(1, "Shubhangi Pandey", new DateTime(2001, 5, 30));

                Student student2 = new Student(2, "Sarika Singh", new DateTime(2001, 4, 28));



                info.Display(student1);

                info.Display(student2);

            }



            // Scenario 2

             void Scenario2()

            {

                Info info = new Info();



                Student[] students = new Student[2];

                students[0] = new Student(3, "Sanchika Bajpai", new DateTime(1997, 7, 19));

                students[1] = new Student(4, "Ayush Gupta", new DateTime(2000, 01, 14));



                foreach (var student in students)

                {
                    info.Display(student);
                }

            }
            // Execute scenarios

            Scenario1();

            Console.WriteLine("\n------------------------\n");

            Scenario2();

            Console.ReadLine();

        }

    }
}
