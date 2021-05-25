using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2._1___uFly
{
				public partial class Form1 : Form
				{
								private Agency uFly;

								public Form1()
								{
												InitializeComponent();
												uFly = new Agency();

												// Init
												initUglyStuff();
												updateInterface(-1);
								}

								private void initUglyStuff()
								{
												string[] destinations = new string[] { "Beijing", "Barcelona", "Milan", "Berlin" };
												string[] flightNames = new string[] { "KL1234", "KL3456", "KL4567", "KL2345" };
												double[] seatCost = new double[] { 500, 40, 60, 30 };
												int[] totalSeatCount = new int[] { 10, 15, 10, 5 };
												int[] bookedSeatCount = new int[] { 5, 10, 1, 5 };

												for (int i = 0; i < flightNames.Length; i++)
												{
																Flight f = new Flight(flightNames[i], destinations[i], totalSeatCount[i], seatCost[i]);

																for (int j = 0; j < bookedSeatCount[i]; j++)
																				f.BookSeat();

																uFly.AddFlight(f);
												}
								}

								private void btnAddflight_Click(object sender, EventArgs e)
								{
												double costPerSeat = Convert.ToDouble(tbCostperseat.Text);
												int amountOfSeats = Convert.ToInt32(nudSeats.Text);
												string flightNumber = tbFlightnumber.Text.Trim();
												string destination = tbDestination.Text.Trim();

												if (amountOfSeats > 0 &&
																costPerSeat > 0 &&
																flightNumber.Length > 0 &&
																destination.Length > 0)
												{
																uFly.AddFlight(new Flight(flightNumber, destination, amountOfSeats, costPerSeat));

																tbFlightnumber.Text = "";
																tbDestination.Text = "";
																tbCostperseat.Text = "";
																nudSeats.Text = "";

																updateInterface(-1);
												}
								}

								private void updateInterface(int availFlightSelectedIndex)
								{
												lbFlights.Items.Clear();
												lbFull.Items.Clear();

												rtbProfit.Text = uFly.GetProfitOverview();
												foreach (Flight f in uFly.GetFullFlights())
												{
																lbFull.Items.Add($"{f.GetFlightNo()} to {f.GetDestination()} has {f.GetBookedSeats()} booked seats for €{f.GetCostPerSeat()} per seat");
												}

												foreach (Flight f in uFly.GetAvailableFlights())
												{
																lbFlights.Items.Add($"{f.GetFlightNo()} to {f.GetDestination()} has {f.GetBookedSeats()}/{f.GetTotalSeats()} seats remaining for €{f.GetCostPerSeat()} per seat");
												}

												if (availFlightSelectedIndex > -1 && lbFlights.Items.Count > availFlightSelectedIndex)
												{
																lbFlights.SelectedIndex = availFlightSelectedIndex;
												}
								}

								private void btnBook_Click(object sender, EventArgs e)
								{
												int seatsToBook = Convert.ToInt32(nudBookSeats.Text);
												int flightIndex = lbFlights.SelectedIndex;

												if (flightIndex > -1)
												{
																Flight selectedFlight = uFly.GetAvailableFlights()[flightIndex];
																selectedFlight.BookSeat(seatsToBook);
																updateInterface(flightIndex);
												}
								}
				}
}