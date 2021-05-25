using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2._4___Administration
{
				public partial class Form1 : Form
				{
								private Course c;

								public Form1()
								{
												InitializeComponent();
												c = new Course("PCS1");
								}

								private void updateInterface()
								{
												// Students
												lbStudents.Items.Clear();
												foreach (Student s in c.AllStudents())
																lbStudents.Items.Add(s.GetInfo());

												// Groups
												lbGroups.Items.Clear();
												foreach (string g in c.Groups)
																lbGroups.Items.Add(g);
								}

								private void searchStudents(TextBox tb)
								{
												string inpText = tb.Text.Trim();
												Student s = null;

												if (inpText.Length > 0)
																s = c.SearchByStudentnumber(Convert.ToInt32(inpText));
												else
												{
																updateInterface();
																return;
												}

												lbStudents.Items.Clear();
												if (s != null)
																lbStudents.Items.Add(s.GetInfo());
								}

								private void searchGroupmembers(TextBox tb)
								{
												string inpText = tb.Text.Trim();
												Student[] students = null;

												if (inpText.Length > 0)
																students = c.SearchByGroup(inpText);

												lbGroupMembers.Items.Clear();
												if (students != null)
												{
																foreach (Student s in students)
																				lbGroupMembers.Items.Add(s.GetInfo());
												}
								}

								private void btnAddStudent_Click(object sender, EventArgs e)
								{
												if (c.AddStudent(tbStudentName.Text, Convert.ToInt32(nudStudentNumber.Text))) {
																nudStudentNumber.Value++;
																updateInterface();
												}
												else
												{
																MessageBox.Show("Unable to add student", "Error");
												}
								}

								private void btnStudentSearch_Click(object sender, EventArgs e)
								{
												searchStudents(tbStudentSearch);
								}

								private void tbStudentSearch_TextChanged(object sender, EventArgs e)
								{
												searchStudents((TextBox)sender);
								}

								private void btnSearchGroupM_Click(object sender, EventArgs e)
								{
												searchGroupmembers(tbSearchGroupM);
								}

								private void tbSearchGroupM_TextChanged(object sender, EventArgs e)
								{
												searchGroupmembers((TextBox)sender);
								}
				}
}
