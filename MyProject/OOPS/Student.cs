using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPS
{
    class Student
    {
        public int student_id;
        public string student_name;
        public int physics;
        public int chem;
        public int maths;
        public int total;
        public int Percentage;
        
        static void Main(String[] args)
        {
            Student Student = new Student();
            Student.student_id = 1;
            Student.student_name = "Radha";
            Student.physics = 65;
            Student.chem = 60;
            Student.maths = 75;
            Student.total = Student.physics + Student.chem + Student.maths;
            Student.Percentage = Student.total / 3;
            Console.WriteLine("Percentage=" + Student.Percentage);
        }

    }
}
