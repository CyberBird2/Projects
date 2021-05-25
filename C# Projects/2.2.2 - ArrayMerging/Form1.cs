using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2._2___ArrayMerging
{
				public partial class Form1 : Form
				{
								public Form1()
								{
												InitializeComponent();
								}

								private int[] handleTB(TextBox tb)
								{
												string[] vals = tb.Text.Split(',');
												int[] outp = new int[vals.Length];

												for (int i = 0; i < vals.Length; i++)
																outp[i] = Convert.ToInt32(vals[i].Trim());

												return outp;
								}

								private void btnOne_Click(object sender, EventArgs e)
								{
												int[] arrayOne = handleTB(tbArray1);
												int[] arrayTwo = handleTB(tbArray2);

												tbResult.Text = String.Join(", ", arrayOne.Concat(arrayTwo));
								}

								private void btnTwo_Click(object sender, EventArgs e)
								{
												int[] arrayOne = handleTB(tbArray1);
												int[] arrayTwo = handleTB(tbArray2);
												int longestArray = (arrayOne.Length > arrayTwo.Length) ? 1 : 2;
												int shortestArray = (longestArray == 1) ? 2 : 1;
												string outpStr = "";

												for (int i = 0; i < (longestArray == 1 ? arrayOne : arrayTwo).Length; i++)
												{
																int[] smallArr = (shortestArray == 1 ? arrayOne : arrayTwo);
																if (i < smallArr.Length)
																				outpStr += smallArr[i] + ", ";

																outpStr += ((longestArray == 1) ? arrayOne : arrayTwo)[i] + ", ";
												}

												tbResult.Text = outpStr.Substring(0, outpStr.Length - 2);
								}

								private void btnThree_Click(object sender, EventArgs e)
								{
												int[] arrayOne = handleTB(tbArray1);
												int[] arrayTwo = handleTB(tbArray2);
												int[] longestArray = (arrayOne.Length > arrayTwo.Length) ? arrayOne : arrayTwo;
												List<int> outpList = new List<int>();

												void handle(int[] arr, int[] otherArr)
												{
																for (int i = 0; i < arr.Length; i++)
																{
																				if (!otherArr.Contains(arr[i]) && !outpList.Contains(arr[i]))
																								outpList.Add(arr[i]);
																}
												}

												handle(arrayOne, arrayTwo);
												handle(arrayTwo, arrayOne);

												tbResult.Text = String.Join(", ", outpList);
								}

								private void btnFour_Click(object sender, EventArgs e)
								{
												int[] arrayOne = handleTB(tbArray1);
												int[] arrayTwo = handleTB(tbArray2);
												int[] longestArray = (arrayOne.Length > arrayTwo.Length) ? arrayOne : arrayTwo;
												List<int> outpList = new List<int>();

												void handle(int[] arr, int[] otherArr)
												{
																for (int i = 0; i < arr.Length; i++)
																{
																				if (otherArr.Contains(arr[i]) && !outpList.Contains(arr[i]))
																								outpList.Add(arr[i]);
																}
												}

												handle(arrayOne, arrayTwo);
												handle(arrayTwo, arrayOne);

												tbResult.Text = String.Join(", ", outpList);
								}
				}
}
