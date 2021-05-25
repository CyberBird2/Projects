using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Assignment_3._2._5_Project2
{
    class Student
    {
        private string Name;
        private int StudentNumber;
        Course StudentCourses = new Course();
        private string CourseNames;

        
        public Student(string name,int StudentNumber)
        {
            this.Name = name;
            this.StudentNumber = StudentNumber;
        }
        public Student(string name,string CourseName,int studentNumber)
        {
            this.Name = name;
            this.StudentNumber = studentNumber;
            this.CourseNames=CourseName ;
                  
        }
        public string GetName
        {
            get
            {
                return Name;
            }
        }
        public int GetStudentNumber
        {
            get
            {
                return StudentNumber;
            }
        }     
        public string GetInfo()
        {
            string info;

            info = "Student Name: " + GetName + " StudentNumber: " + " Student Group Name: " + StudentCourses.CourseNames;
            return info;
        }


    }
}
