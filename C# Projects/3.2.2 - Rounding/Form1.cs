using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2._2___Rounding
{
				public partial class Form1 : Form
				{
								public Form1()
								{
												InitializeComponent();
								}

								private void btnAct_Click(object sender, EventArgs e)
								{
												double num = Convert.ToDouble(tbNumber.Text);
												void preform(int decimals)
												{
																for (int i = 0; i < 10; i++)
																				lbOutp.Items.Add(CrazyMath.Round(num, decimals));
												}

												lbOutp.Items.Clear();

												if (rbWhole.Checked)
																preform(0);
												else if (rbTenth.Checked)
																preform(1);
												else if (rbHundred.Checked)
																preform(2);
												else
																preform(0);
								}
				}
}
