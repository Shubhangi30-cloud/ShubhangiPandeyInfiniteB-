using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment_4
{
    class student
    {
        public int rollno;
        public string name;
        public string class_name;
        public string semester;
        public string branch;
        public int[] marks = new int[5];



        public student(int rollno, string name, string class_name, string semester, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.class_name = class_name;
            this.semester = semester;
            this.branch = branch;
        }
        public void GetMarks()
        {
            Console.WriteLine("Enter marks of 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1} Marks: ");
                if (int.TryParse(Console.ReadLine(), out int subjectMark))
                {
                    marks[i] = subjectMark;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    i--;
                }
            }
        }
        public void DisplayResult()
        {
            int totalMarks = 0;
            foreach (int mark in marks)
            {
                totalMarks += mark;
            }
            double averageMarks = totalMarks / 5.0;
            Console.WriteLine($"Average Marks :{averageMarks}");
            bool failed = false;



            foreach (int mark in marks)
            {
                if (mark < 35)
                {
                    Console.WriteLine("*==*Result: Failed*==*");
                    failed = true;
                    break;
                }
            }
            if (!failed)
            {
                if (averageMarks < 50)
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    Console.WriteLine("Result: Passed");
                }
            }
        }



        public void DisplayData()
        {
           Console.WriteLine("Detail of the student: ");
            Console.WriteLine("Roll No: " + rollno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: " + class_name);
            Console.WriteLine("Semester: " + semester);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Marks");
            Console.WriteLine("Marks: " + string.Join(", ", marks));
        }
    }



    class part2
    {
        static void Main()
        {
            Console.Write("Enter Roll No: ");
            int rollno = int.Parse(Console.ReadLine());



            Console.Write("Enter Name: ");
            string name = Console.ReadLine();



            Console.Write("Enter Class: ");
            string class_name = Console.ReadLine();



            Console.Write("Enter Semester: ");
            string semester = Console.ReadLine();



            Console.Write("Enter Branch: ");
            string branch = Console.ReadLine();



            student student = new student(rollno, name, class_name, semester, branch);
            student.GetMarks();
            student.DisplayData();
            student.DisplayResult();
            Console.Read();
        }

    }
}
