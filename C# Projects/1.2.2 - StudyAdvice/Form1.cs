using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2._2___StudyAdvice
{
				public partial class Form1 : Form
				{
								public Form1()
								{
												InitializeComponent();
								}

								private int[] getValues()
								{
												int getValueFromNUD(NumericUpDown nud)
												{
																if (nud.Text == "" || nud.Text.Trim() == "0")
																				return -1;
																else
																				return Convert.ToInt32(nud.Text);
												}

												return new int[] { getValueFromNUD(nudBlock1), getValueFromNUD(nudBlock2), getValueFromNUD(nudBlock3), getValueFromNUD(nudBlock4) };
								}

								private void btnCalculate_Click(object sender, EventArgs e)
								{
												int[] values = getValues();

												if (values.All(val => val < 0))
																MessageBox.Show("No advice available");
												else if (values[1] < 0 || values[2] < 0 || values[3] < 0)
																new StudyAdvice(values[0]);
												else if (values[2] < 0 || values[3] < 0)
																new StudyAdvice(values[0], values[1]);
												else if (values[3] < 0)
																new StudyAdvice(values[0], values[1], values[2]);
												else
																new StudyAdvice(values[0], values[1], values[2], values[3]);
								}
				}

				public class StudyAdvice
				{
								private enum StudyAdvices { A, B, C, D, UNDEFINED };

								public StudyAdvice(float block1)
								{
												doTheStuff((block1 / (float)15 * 100));
								}

								public StudyAdvice(float block1, float block2)
								{
												doTheStuff(((block1 + block2) / (float)(15 * 2) * 100));
								}

								public StudyAdvice(float block1, float block2, float block3)
								{
												doTheStuff(((block1 + block2 + block3) / (float)(15 * 3) * 100));
								}

								public StudyAdvice(float block1, float block2, float block3, float block4)
								{
												doTheStuff(((block1 + block2 + block3 + block4) / (float)(15 * 4) * 100));
								}

								private void doTheStuff(float percentage)
								{
												StudyAdvices studyAdvice = GetStudyadviceFromNum(percentage);

												if (studyAdvice == StudyAdvices.UNDEFINED)
																MessageBox.Show("SOMETHING WENT WRONG: " + percentage, "Error");
												else
																MessageBox.Show($"Your study advice is: {studyAdvice.ToString()}!");
								}

								private StudyAdvices GetStudyadviceFromNum(float num)
								{
												if (num == 100)
																return StudyAdvices.A;
												else if (num > 75)
																return StudyAdvices.B;
												else if (num > 50)
																return StudyAdvices.C;
												else if (num <= 50)
																return StudyAdvices.D;
												else
																return StudyAdvices.UNDEFINED;
								}
				}
}
