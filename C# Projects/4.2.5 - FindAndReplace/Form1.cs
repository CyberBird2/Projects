using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2._5___FindAndReplace
{
				public partial class Form1 : Form
				{
								private Font regularFont;
								private Font boldFont;

								public Form1()
								{
												InitializeComponent();

												regularFont = new Font(rtbResult.Font, FontStyle.Regular);
												boldFont = new Font(rtbResult.Font, FontStyle.Bold);
								}

								private void btnFind_Click_OLD(object sender, EventArgs e)
								{
												string text = rtbOriginal.Text;
												string strToFind = tbFind.Text;

												string newString = @"{\rtf1\ansi " + text + "}";
												int lastIndex = text.IndexOf(strToFind, 0);
												int looped = 0;
												while (lastIndex > -1 && looped < text.Length * 10)
												{
																newString = stringReplaceAt(newString, lastIndex, strToFind.Length, $"\b {strToFind}\b0");
																lastIndex = text.IndexOf(strToFind, lastIndex);
																looped++;
												}

												rtbResult.Rtf = newString;
								}

								// Broken. I don't know why ¯\_(ツ)_/¯
								private void btnFind_Click(object sender, EventArgs e)
								{
												rtbResult.Text = "";

												try
												{
																string text = rtbOriginal.Text;
																string strToFind = tbFind.Text;

																int lastIndex = text.IndexOf(strToFind, 0);
																int prevIndex = 0;
																int looped = 0;
																while (lastIndex > -1 && looped < text.Length * 2)
																{
																				rtbResult.AppendText(text.Substring(prevIndex, lastIndex));
																				rtbResult.SelectionFont = boldFont;
																				rtbResult.AppendText(text.Substring(lastIndex, strToFind.Length));
																				rtbResult.SelectionFont = regularFont;
																				Console.WriteLine(rtbResult.Text);

																				prevIndex = lastIndex + strToFind.Length;
																				lastIndex = text.IndexOf(strToFind, lastIndex + 1);
																				looped++;

																}

																rtbResult.AppendText(text.Substring(prevIndex));
												} catch (Exception ex)
												{
																Console.WriteLine(ex.StackTrace);
												}
								}

								private string stringReplaceAt(string str, int startPos, int origStrLength, string strToPlace)
								{
												return str.Remove(startPos, origStrLength).Insert(startPos, strToPlace);
								}

        private void btnReplace_Click(object sender, EventArgs e)
        {

        }
    }
}
