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
				public partial class CourseResultsForm : Form
				{
								public CourseResultsForm(string[] info)
								{
												InitializeComponent();
												lbResults.Items.AddRange(info);
								}

								private void btnClose_Click(object sender, EventArgs e)
								{
												this.Close();
								}
				}
}
