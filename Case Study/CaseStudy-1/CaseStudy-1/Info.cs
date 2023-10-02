using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_1
{
    class Info
    {
        public void Display(Student student)

        {

            Console.WriteLine($"Student ID: {student.Id}");

            Console.WriteLine($"Name: {student.Name}");

            Console.WriteLine($"Date of Birth: {student.DateOfBirth.ToShortDateString()}");

        }
    }
}
