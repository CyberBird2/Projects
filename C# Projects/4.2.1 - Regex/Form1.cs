using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2._1___Regex
{
				public partial class Form1 : Form
				{
								public Form1()
								{
												InitializeComponent();
								}

								private void handleCheck(Func<string, bool> func)
								{
												bool valid = (func(cbbInput.Text));

												if (valid)
																cbbInput.Items.Add(cbbInput.Text);

												MessageBox.Show(valid ? "Yes!" : "Nope!");
								}

								private void btnValidPhoneNumber_Click(object sender, EventArgs e)
								{
												handleCheck(RegexPlayground.ValidPhoneNumber);
								}

								private void btnDutchPhoneNumber_Click(object sender, EventArgs e)
								{
												handleCheck(RegexPlayground.ValidDutchPhoneNumber);
								}

								private void btnValidStreetname_Click(object sender, EventArgs e)
								{
												handleCheck(RegexPlayground.ValidStreetName);
								}

								private void btnValidAddresss_Click(object sender, EventArgs e)
								{
												handleCheck(RegexPlayground.ValidAddress);
								}

								private void btnPatternCount_Click(object sender, EventArgs e)
								{
												string inpRegex = cbbPattern.Text;
												string text = tbxTestData.Text;

												MessageBox.Show(RegexPlayground.RegexCount(text, inpRegex).ToString());
												cbbPattern.Items.Add(cbbPattern.Text);
								}
				}
}
