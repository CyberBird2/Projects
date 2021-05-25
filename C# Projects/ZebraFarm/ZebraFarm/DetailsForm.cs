using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZebraFarm
{
    public partial class DetailsForm : Form
    {
								private Zebra z;

        public DetailsForm(int zebraId)
        {
            InitializeComponent();

												z = Form1.farm.GetZebra(zebraId);
												if (z == null) {
																MessageBox.Show("No zebra found", "Error");
																gbxZebra.Enabled = false;
												} else
												{
																gbxZebra.Text = "Zebra with id " + z.GetId();
																tbxZebraName.Text = z.Name;
																
																switch(z.Gender)
																{
																				case Gender.MARE:
																								rbnZebraGenderMare.Checked = true;
																								break;
																				case Gender.STALLION:
																								rbnZebraGenderStallion.Checked = true;
																								break;
																				case Gender.UNKNOWN:
																								rbnZebraGenderUnknown.Checked = true;
																								break;
																}
												}
        }

        private void btnUpdateAndClose_Click(object sender, EventArgs e)
        {
												if (rbnZebraGenderMare.Checked)
																z.Gender = Gender.MARE;
												else if (rbnZebraGenderStallion.Checked)
																z.Gender = Gender.STALLION;
												else if (rbnZebraGenderUnknown.Checked)
																z.Gender = Gender.UNKNOWN;
												else
												{
																MessageBox.Show("Gender error: Unknown gender type (not to be confused with the type of gender 'Unkown')", "Error");
																this.Close();
																return;
												}

												z.Name = tbxZebraName.Text;
												this.Close();
        }
    }
}
