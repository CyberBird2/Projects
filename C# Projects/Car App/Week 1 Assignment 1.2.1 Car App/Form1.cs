using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_1_Assignment_1._2._1_Car_App
{
    public partial class Form1 : Form
    {
        Car Car1;
        Car Car2;
        Car Car3;
        Car Car4;
        Car Car5;
        Car selectedCar;
        public Form1()
        {
            InitializeComponent();

            carComboBox.Items.Add(Car1 = new Car("NHRWQ", 200));
            carComboBox.Items.Add(Car2 = new Car("THEQW", 300));
            carComboBox.Items.Add(Car3 = new Car("ZCXZC", 400));
            carComboBox.Items.Add(Car4 = new Car("LKASD", 500));
            carComboBox.Items.Add(Car5 = new Car("BNBYT", 600));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Casting
            //Hocanin Yaptiginada bakabilirsin
            selectedCar = (Car) carComboBox.SelectedItem;

           
        }
        private bool isCarSelected()
        {
            if (selectedCar == null)
            {
                
                MessageBox.Show("Please Chose Your Car");
                return false;
            }
            else
            {
                return true;

            }

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
          
            if (this.isCarSelected())
            {
                selectedCar.SetUnderMaintenance(true);
            }
         

           
        }

        private void btnRefuel_Click(object sender, EventArgs e)
        {
            if (this.isCarSelected())
            {
                int Fuel = Convert.ToInt32(tbLitre.Text);
                selectedCar.AddFuel(Fuel);
            }
           
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (this.isCarSelected())
            {
                selectedCar.SetSold();
            }
            

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            lbInfo.Items.Add(selectedCar.GetInfo());
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          
            if (this.isCarSelected())
            {
                if (tBDistance.Text == "")
                {
                    MessageBox.Show("Please Enter Your Km Or Distance");
                    return;
                }

                selectedCar.drive(Convert.ToInt32(tBDistance.Text));
            }
            



        }
    }
}
