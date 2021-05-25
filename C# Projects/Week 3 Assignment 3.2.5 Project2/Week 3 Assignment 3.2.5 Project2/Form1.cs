using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3_Assignment_3._2._5_Project2
{
    public partial class Form1 : Form
    {
        Course MyCourse = new Course();
        ProjectGroup MyProjectGroup;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudentToProjectGroups_Click(object sender, EventArgs e)
        {
            string StudentName = tBStudentName.Text;
            int StudentNumber = Convert.ToInt32(tBStudentNumber.Text);
            string GroupName = tBProjectGroupName.Text;
          
                
        }
    }
}
