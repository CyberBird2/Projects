using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3ProjectCourseAdmin
{
    public partial class Form1 : Form
    {
        Course myCourse = new Course();
        
        public Form1()
        {
            InitializeComponent();
            myCourse.groups.Add(new ProjectGroup("course1"));
            myCourse.groups.Add(new ProjectGroup("course2"));
            myCourse.groups.Add(new ProjectGroup("course3"));
            myCourse.groups.Add(new ProjectGroup("course4"));
            myCourse.students.Add(new Student("abebe", "rhjv", 12334));
            myCourse.students.Add(new Student("abebe", "rhjv", 12334));
            myCourse.students.Add(new Student("abebe", "rhjv", 12334));
            myCourse.students.Add(new Student("abebe", "rhjv", 12334));
            myCourse.students.Add(new Student("abebe", "rhjv", 12334));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btShowGroups_Click(object sender, EventArgs e)
        {
            List<ProjectGroup> projectgroups = myCourse.GetAllGroups(); 
            

            foreach(ProjectGroup pg in projectgroups)
            {
                lbGroups.Items.Add("Group name: " + pg.Name);
            }
        }

        private void btShowAllStudents_Click(object sender, EventArgs e)
        {
            List<Student> students = myCourse.GetAllStudents();
            foreach (Student stu in students)
            {
                listBox1.Items.Add("student name is" + stu.Name);
            }

        }
    }
}
