using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3_Assignment_3._2._2_Crazy_Round
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            decimal number = Convert.ToDecimal(tbNumber.Text);

            if (rbWhole.Checked)
            {
                decimal roundWhole = Math.Round(number);

                lbShow.Items.Add(roundWhole);
            }
            else if (rbTenth.Checked)
            {
                decimal roundTent = Math.Round(number * 10) / 10; 

                lbShow.Items.Add(roundTent);
            }
            else if (rbHundereth.Checked)
            {
                decimal roundHundeth = Math.Round(number * 100) / 100;
                lbShow.Items.Add(roundHundeth);

            }


        }

       
    }
}
