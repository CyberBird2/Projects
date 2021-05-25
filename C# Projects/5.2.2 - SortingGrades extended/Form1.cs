using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2._1___SortingGrades
{
				public partial class Form1 : Form
				{
								Administration administration;

								public Form1()
								{
												administration = new Administration();
												InitializeComponent();
												ShowList();

												cbCourses.Items.AddRange(administration.GetCourseNames());
								}

								private void ShowList()
								{
												lbResults.Items.Clear();
												foreach (AcademicResult r in administration.GetResults())
																lbResults.Items.Add(r.GetInfo());
								}

								private void btnSort_Click(object sender, EventArgs e)
								{
												administration.SortByGrade();
												ShowList();
								}

								private void btnRandomize_Click(object sender, EventArgs e)
								{
												administration.RandomizeResults();
												ShowList();
								}

								private void btnShow_Click(object sender, EventArgs e)
								{
												
												(new CourseResultsForm(administration.GetResultsStrings(cbCourses.SelectedItem.ToString()))).Show();
								}
				}
}
