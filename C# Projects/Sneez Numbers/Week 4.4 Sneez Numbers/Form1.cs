using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_4._4_Sneez_Numbers
{
    public partial class Form1 : Form
    {
        SneezCalculator sneezcalculator;
        public Form1()
        {
            InitializeComponent();
            sneezcalculator = new SneezCalculator();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                int value = sneezcalculator.GetSneezNumber(Convert.ToInt32(tbinput.Text));
                MessageBox.Show(value.ToString());
            }
            catch(FormatException)
            {
                MessageBox.Show("Please input numbers only");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index out of range!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero");
            }
            catch (NoSuchSneezNumberException ez)
            {
                MessageBox.Show(ez.Message);
            }
            

        }
    }
}
