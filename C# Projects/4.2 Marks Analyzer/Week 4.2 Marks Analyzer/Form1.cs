using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_4._2_Marks_Analyzer
{
    public partial class Form1 : Form
    {
        Student myStudent;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncreatestudent_Click(object sender, EventArgs e)
        {
            try
            {
                myStudent = new Student(tbname.Text, Convert.ToInt32(tbstudentnumber.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number as a student number! ");
            }
            

           
        }

        private void btnaddmark_Click(object sender, EventArgs e)
        {
            try
            {
                myStudent.AddMark(Convert.ToInt32(tbnewmark.Text));
                lbResult.Items.Add(tbnewmark.Text);
            }
            catch(MarkOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
          
        }

        private void btncalculateavg_Click(object sender, EventArgs e)
        {
            try
            {
                myStudent.CalculateAverageMark();
                lbaverageresult.Text = myStudent.CalculateAverageMark().ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please create a student first! ");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Please first add mark!");
            }

            
        }
    }
}
