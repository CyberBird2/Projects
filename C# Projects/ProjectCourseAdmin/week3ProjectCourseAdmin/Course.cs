using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3ProjectCourseAdmin
{
    class Course
    {
        public List<ProjectGroup> groups { set; get; }
        public List<Student> students { set; get; }

        

        public Course()
        {
            groups = new List<ProjectGroup>();
            students = new List<Student>();
        }
        public bool AddStudents(string name, ProjectGroup pg, int StudentNumber)
        {
            foreach(Student std in students)
            {
                if(StudentNumber == std.StudentNumber)
                {
                    return false;
                }

                else
                {

                    foreach (ProjectGroup _pg in groups)
                    {
                        if (pg == _pg && pg.students.Count < 3)
                        {
                            Student a = new Student(name, pg.Name, StudentNumber);
                            students.Add(a);
                            pg.students.Add(a);
                        }
                        else if (pg == _pg && pg.students.Count >= 3)
                        {
                            Student a = new Student(name, pg.Name, StudentNumber);
                            students.Add(a);
                            ProjectGroup project = new ProjectGroup(name);
                            project.students.Add(a);


                        }
                    }

                   
                }

            }

            return true;
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public List<ProjectGroup>GetAllGroups()
        {
            return groups;
        }

         
       public Student student(int _studentNumber)
        {
            foreach(Student a in students)
            {
                if(a.StudentNumber == _studentNumber)
                {
                    return a;
                }
            }
            return null;
        }

       public List<Student> ShowStudents(string name)
        {
            List<Student> temp = new List<Student>();
            foreach(ProjectGroup pg in groups)
            {
                if(pg.Name == name)
                {
                    foreach(Student a in pg.students)
                    {
                        temp.Add(a);
                    }
                }
            }

            return temp;
        }

        public int GetStudentCount()
        {
            return students.Count;
        }

        public int GetProjectCount()
        {
            return groups.Count;
        }


    }
}
