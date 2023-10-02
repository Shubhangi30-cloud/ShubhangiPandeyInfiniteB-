﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        // Constructor
        public Student(int id, string name, DateTime dateOfBirth)

        {

            Id = id;

            Name = name;

            DateOfBirth = dateOfBirth;

        }
    }
}