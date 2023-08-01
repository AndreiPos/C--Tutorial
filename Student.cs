using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 23. Object Methods
namespace C__Tutorial
{
    class Student
    {
        public string name;
        public string course;
        public double grade;

        public Student(string aName, string aCourse, double aGrade)
        {
            name = aName;
            course = aCourse;
            grade = aGrade;
        }

        // Method
        public bool HasHonours()
        {
            if (grade >= 69.5)
            {
                return true;
            }
            return false;
        }
    }
}
