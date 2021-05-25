using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_4_Assignment
{
    public partial class SimpleCalculator : Form
    {
        double result;
        int Number1;
        int Number2;
        string InfoResult;
        public SimpleCalculator()
        {
            
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sumbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Number1 = Convert.ToInt32(number1textbx.Text);
                Number2 = Convert.ToInt32(number2textbx.Text);

                result = Number1 + Number2;

                InfoResult = Number1 + " + " + Number2 + "  = " + result;



            }
            catch(FormatException)
            {
                InfoResult = "Please enter numbers ";
            }
            finally
            {
                InfoText.AppendText(InfoResult + Environment.NewLine);

            }
        }
        private void Substractingbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Number1 = Convert.ToInt32(number1textbx.Text);
                Number2 = Convert.ToInt32(number2textbx.Text);

                result = Number1 - Number2;

                InfoResult = Number1 + " - " + Number2 + "  = " + result;



            }
            catch(FormatException)
            {
                InfoResult = "Please enter numbers ";
            }
            finally
            {
                InfoText.AppendText(InfoResult + Environment.NewLine);

            }
        }

        private void Divisionbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Number1 = Convert.ToInt32(number1textbx.Text);
                Number2 = Convert.ToInt32(number2textbx.Text);

                result = Number1 / Number2;

                InfoResult = Number1 + " / " + Number2 + "  = " + result;



            }
            catch(FormatException)
            {
                InfoResult = "Please enter numbers ";
            }
            catch(DivideByZeroException)
            {
                InfoResult = "Number 2 cannot be zero when you divide !";
            }
            finally
            {
                InfoText.AppendText(InfoResult + Environment.NewLine);

            }
        }

        private void multibtn_Click(object sender, EventArgs e)
        {
            try
            {
                Number1 = Convert.ToInt32(number1textbx.Text);
                Number2 = Convert.ToInt32(number2textbx.Text);

                result = Number1 * Number2;

                InfoResult = Number1 + " * " + Number2 + "  = " + result;



            }
            catch(FormatException)
            {
                InfoResult = "Please enter numbers ";
            }
            finally
            {
                InfoText.AppendText(InfoResult + Environment.NewLine);

            }
        }
    }
}
