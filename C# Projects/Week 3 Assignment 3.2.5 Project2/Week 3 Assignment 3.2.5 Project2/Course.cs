using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Assignment_3._2._5_Project2
{
    class Course
    {
        public List<Student> studentList;
        public List<ProjectGroup> Projectgroups;
        private string Coursename;
        public Course(){ }
        public Course(string name)
        {
            Projectgroups = new List<ProjectGroup>();
            this.Coursename = name;
            studentList = new List<Student>();
            
        }
        public string CourseNames
        {
            get
            {
                return Coursename;
            }
            set
            {
                Coursename = value;
            }
        }
        // Adding Students to do Courses(PCS2,FIS2)
        public void AddStudentsToCourses(string name,int studentNumber,string CourseName)
        {
            bool exist = false;
            bool ProjectGroupExist = false;
            foreach (Student searchstudent in studentList)
            {
                if (searchstudent.GetStudentNumber == studentNumber)
                {
                    exist = true;
                    
                }
            }
            if()
          
          
        }
        // Get all Students
        public List<Student> GetAllStudents()
        {
            return studentList;
        }
        //Search Student by studentnumber
        public Student searchstudents(int _studentNumber)
        {
            foreach ( Student searchStudent in studentList)
            {
                if (searchStudent.GetStudentNumber == _studentNumber)
                {
                    return searchStudent;
                }
                else
                {
                    string info = "This Student Does Not Exist";
                }
            }
            return null;
        }
        public int GetStudentsCount()
        {
            return studentList.Count;
        }
        public int GetGroupsCount()
        {
            return Projectgroups.Count;
        }

  
    }
}
