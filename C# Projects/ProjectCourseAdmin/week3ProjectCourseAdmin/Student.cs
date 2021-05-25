using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3ProjectCourseAdmin
{
    public class Student
    {
        private string name;
        private int studentNumber;
        private string groupName;

        public Student()
        {

        }

        public string Name
        {
            get
            {

                return name;
            }
            set
            {

                if (this.name != "")
                {
                    this.name = value;
                }
                else

                {
                    name = "unknown";
                }
            }
        }
        public int StudentNumber
        {
            get
            {

                return studentNumber;
            }
            set
            {
                if (studentNumber <= 1000 && studentNumber >= -1)
                {
                    this.studentNumber = value;
                }
            }
        }
        public string GroupName
        {
            get { return groupName; }
            set
            {
                if (groupName != "")
                {
                    this.groupName = value;
                }
            }
        }
        public Student(string name, string groupName, int studentNumber)
        {
            Name = name;
            GroupName = groupName;
            StudentNumber = studentNumber;
        }
        public string GetInfo()
        {
            string info = "this student name is" + name + " studentNumber" + studentNumber + "group name" + groupName;
            return info;
        }
    }
}
