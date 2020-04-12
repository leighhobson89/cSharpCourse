using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectMethods
{
    class Student
    {
        public string name;
        public string course;
        public double gpa;

        public Student(string aName, string aCourse, double aGpa) //constructor ( public Student() )
        {
            name = aName;
            course = aCourse;
            gpa = aGpa;
        }

        public bool HasHonours() // object method to check if gpa of objects are high enough to be honour degree
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
