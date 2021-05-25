using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            uFly = new Agency();
        }
        Agency uFly;
        Flight Flights;

      
        private void btAddFlight_Click(object sender, EventArgs e)
        {

            
            string FlightNo = tbFlightNo.Text;
            string destination = tbDestination.Text;
            int CostPerSeat = Convert.ToInt32(tbCostPerSeat.Text);
            int numberofseats = Convert.ToInt32(nudAmountOfSeats.Text);

            Flights = new Flight(FlightNo, destination, numberofseats,CostPerSeat);

            uFly.AddFlight(Flights);

            lbAvailableFlights.Items.Add(Flights.GetInfo().ToString());
        }

        private void btBookSeat_Click(object sender, EventArgs e)
        {
            
            string BookFlightNo = tbBookFlightNo.Text;
            
            uFly.BookSeat(BookFlightNo);

            

            if (Flights.FullyBooked())
            {
                lbFullFlights.Items.Add(Flights.GetInfo().ToString());
            }
            else
            {
                lbAvailableFlights.Items.Add(Flights.GetInfo().ToString());
            }
           
            
        
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            tbProfit.Text = uFly.GetProfitOverview();
        }
    }
}
