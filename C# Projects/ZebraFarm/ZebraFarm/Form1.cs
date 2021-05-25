using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZebraFarm
{
    public partial class Form1 : Form
    {
								private Regex intRegex = new Regex(@"^\d+$");
								public static ZebraFarm farm;

        public Form1()
        {
            InitializeComponent();

												string farmName = "FarmyMcFarmington";
												farm = new ZebraFarm(farmName);
												this.Text = farmName;

												cbxZebraFilter.SelectedIndex = 0;
								}

        private void btnFilterZebras_Click(object sender, EventArgs e)
        {
												lbxZebras.Items.Clear();

												void AddArrToLb(Zebra[] items)
												{
																foreach (Zebra z in items)
																				lbxZebras.Items.Add(z);
												}
												
												switch(cbxZebraFilter.SelectedIndex)
												{
																case 0:
																				AddArrToLb(farm.GetZebras());
																				break;
																case 1:
																				AddArrToLb(farm.GetZebras(Gender.MARE));
																				break;
																case 2:
																				AddArrToLb(farm.GetZebras(Gender.STALLION));
																				break;
																case 3:
																				AddArrToLb(farm.GetZebras(Gender.UNKNOWN));
																				break;
												}
        }

								private void btnAttemptBreeding_Click(object sender, EventArgs e)
								{
												string motherIdStr = tbxMotherId.Text;
												string fatherIdStr = tbxFatherId.Text;

												if (IsValidInt(motherIdStr) && IsValidInt(fatherIdStr))
												{
																int motherId = Convert.ToInt32(motherIdStr);
																int fatherId = Convert.ToInt32(fatherIdStr);

																try
																{
																				if (!farm.AttemptToBreed(motherId, fatherId))
																								MessageBox.Show("Nothing happened", "Result");
																				else
																				{
																								MessageBox.Show("A zebra is born", "Result");
																								btnFilterZebras_Click(null, null);
																				}
																} catch (Exception err)
																{
																				MessageBox.Show(err.Message, "Error");
																}
												}
												else
												{
																MessageBox.Show("Invalid id", "Error");
												}
								}

        private void btnShowZebra_Click(object sender, EventArgs e)
        {
												string zebraIdStr = tbxSearchZebra.Text;

												if (IsValidInt(zebraIdStr))
																new DetailsForm(Convert.ToInt32(zebraIdStr)).ShowDialog();
												else
																MessageBox.Show("No zebra found: Invalid id", "Error");
        }    
								
								private bool IsValidInt(string val)
								{
												return intRegex.IsMatch(val);
								}
				}
}
