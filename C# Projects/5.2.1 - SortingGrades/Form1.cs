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
								private List<AcademicResult> results;
								private Random r;

								public Form1()
								{
												results = new List<AcademicResult>();
												InitializeComponent();
												r = new Random();

												results.Add(new AcademicResult("John Doe", 123456, "PCS1", 8.5));
												results.Add(new AcademicResult("John Doe", 123456, "PCS2", 5.6));
												results.Add(new AcademicResult("John Doe", 123456, "EDB1", 5.6));
												results.Add(new AcademicResult("Jane Doe", 134679, "PCS1", 7.5));
												results.Add(new AcademicResult("Alice Jansen", 654321, "EDB1", 9.5));
												results.Add(new AcademicResult("Alice Jansen", 654321, "PCS1", 9.6));

												ShowList();
								}

								private void ShowList()
								{
												lbResults.Items.Clear();
												foreach (AcademicResult r in results)
																lbResults.Items.Add(r.GetInfo());
								}

								private void btnSort_Click(object sender, EventArgs e)
								{
												results.Sort();
											 ShowList();
								}

								private void btnRandomize_Click(object sender, EventArgs e)
								{
												// https://stackoverflow.com/questions/273313/randomize-a-listt
												int n = results.Count;
												while (n > 1)
												{
																n--;
																int k = r.Next(n + 1);
																AcademicResult value = results[k];
																results[k] = results[n];
																results[n] = value;
												}

												ShowList();
								}
				}
}
