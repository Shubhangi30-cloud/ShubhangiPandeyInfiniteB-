create database CaseStudy5
use CaseStudy5

CREATE TABLE Courses (
    course_id INT PRIMARY KEY,
    course_name varchar(255) NOT NULL
);

-- Create the Students table
CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    student_name varchar(255) NOT NULL,
    student_dob DATE NOT NULL
);

CREATE TABLE Enrollments (
   
    student_id INT FOREIGN KEY REFERENCES Students(student_id),
    course_id INT FOREIGN KEY REFERENCES Courses(course_id),
    enrollment_date DATETIME NOT NULL,
);

select * from Students

select * from Courses
insert into Courses values (1,'Python'),(2,'Web Development'),(3,'Devops'),(4,'Mern Stack ')


select * from Enrollments