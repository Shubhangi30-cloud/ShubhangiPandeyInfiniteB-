using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBased_test2
{

    public abstract class Student

    {

        public string Name;

        public int StudentId;

        public int Grade;

        public abstract bool Ispassed(int grade);

    }



    class Undergraduate : Student

    {

        public Undergraduate(string Name, int StudentId, int Grade)

        {

            this.Name = Name;

            this.StudentId = StudentId;

            this.Grade = Grade;

        }

        public override bool Ispassed(int grade)

        {

            if (grade > 70)

            {

                return true;

            }

            else

            {

                return false;

            }

        }

    }

    class Grad : Student

    {

        public Grad(string Name, int StudentId, int Grade)

        {

            this.Name = Name;

            this.StudentId = StudentId;

            this.Grade = Grade;

        }


        public override bool Ispassed(int grade)

        {

            if (grade > 80)

            {

                return true;

            }

            else

            {

                return false;

            }

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            Undergraduate undergraduate = new Undergraduate("Shubhangi", 123, 90);

            Undergraduate undergraduate1 = new Undergraduate("Sakshi", 124, 50);

            Grad grad = new Grad("Shubhangi", 123, 90);

            Grad grad1 = new Grad("Sakshi", 124, 70);

        }

    }

}

