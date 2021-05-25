using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2._4___NewLanguage
{
                public partial class Form1 : Form
			    {
								private PictureBox[] correctness;
								private string[] questionAnswers;
								private Label[] wordsSentences;
								private TextBox[] givenAnswers;
								private Test test;

								public Form1()
								{
												InitializeComponent();

												// Store reference of controls for easy processing
												wordsSentences = new Label[] { lblQuestion1, lblQuestion2, lblQuestion3, lblQuestion4, lblQuestion5, lblQuestion6, lblQuestion7, lblQuestion8, lblQuestion9, lblQuestion10, lblQuestion11 };
												givenAnswers = new TextBox[] { tbQuestion1, tbQuestion2, tbQuestion3, tbQuestion4, tbQuestion5, tbQuestion6, tbQuestion7, tbQuestion8, tbQuestion9, tbQuestion10, tbQuestion11 };
												correctness = new PictureBox[] { pbQuestion1, pbQuestion2, pbQuestion3, pbQuestion4, pbQuestion5, pbQuestion6, pbQuestion7, pbQuestion8, pbQuestion9, pbQuestion10, pbQuestion11 };

												questionAnswers = new string[] { "Hallo", "Hoe gaat het", "Het spijt me", "Ja", "Nee", "Ik ben...", "Wat is jouw naam", "Dankje", "Hoe duur is dit", "Ik begrijp het niet", "Doei" };
												string[] regexAnswerCheckers = new string[] { @"^(hallo|hoi|goede\s+?(n)?dag)$", @"^(hoe\s+gaat\s+het(\?)?)$", @"^(het\s+spijt\s+me)$", @"^(ja)$", @"^(nee)$", @"^(ik\s+ben((\s+)?(\.\.\.))?)$", @"^(wat\s+is\s+jouw\s+naam(\?)?)$", @"^(dank\s+?(u|je)(\s+?wel)?)$", @"^((hoe\s+duur\s+is\s+d(i|a)t(\?)?|(wat|hoeveel)\s+kost\s+dit(\?)?))$", @"^(ik\s+begrijp\s+het\s+niet)$", "^(doei|daag|dag|goedendag|houdoe)$" };


												Question[] questions = new Question[wordsSentences.Length];
												for (int i = 0; i < wordsSentences.Length; i++)
																questions[i] = new Question(wordsSentences[i].Text, questionAnswers[i], regexAnswerCheckers[i]);

												test = new Test("Dutch", questions);
								}

								private void btnFinished_Click(object sender, EventArgs e)
								{
												string[] answers = new string[givenAnswers.Length];
												((Button)sender).Enabled = false;
												btnRestart.Enabled = true;

												for (int i = 0; i < givenAnswers.Length; i++)
												{
																answers[i] = givenAnswers[i].Text;
																givenAnswers[i].Enabled = false;
												}

												bool[] correctedAnswers = test.CheckAnswers(answers);
												if (correctness.Length <= correctedAnswers.Length)
												{
																for (int i = 0; i < correctedAnswers.Length; i++)
																{
																				if (correctedAnswers[i])
																								correctness[i].Image = Properties.Resources.Good;
																				else
																								correctness[i].Image = Properties.Resources.Fault;
																}
												}

												tbResults.Text = test.GetResults();
								}

								private void btnRestart_Click(object sender, EventArgs e)
								{
												((Button)sender).Enabled = false;
												btnFinished.Enabled = true;

												foreach (TextBox tb in givenAnswers)
												{
																tb.Enabled = true;
																tb.Text = "";
												}

												foreach (PictureBox pb in correctness)
																pb.Image = null;
								}
				}
}
