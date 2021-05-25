using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2._1___Car
{
				public partial class Form1 : Form
				{
								private Car[] cars;

								private Random r;

								public Form1()
								{
												InitializeComponent();
												r = new Random();

												// Init cars
												cars = new Car[5];
												for (int i = 0; i < cars.Length; i++)
												{
																cars[i] = new Car("Car " + (i + 1), r.Next(1, 10), r.NextDouble());
																// Update list
																cbCar.Items.Add(cars[i].GetLicensePlate());
												}
												cbCar.SelectedIndex = 0;
												updateInterface(null);
								}

								private Car getCurrentlySelectedCar()
								{
												return cars[cbCar.SelectedIndex];
								}

								private void updateInterface(Car selectedCar)
								{
												if (selectedCar == null)
																selectedCar = getCurrentlySelectedCar();

												lblStatus.Text = selectedCar.GetInfo();
								}

								private void cbCar_SelectedIndexChanged(object sender, EventArgs e)
								{
												updateInterface(null);
								}

								private void btnMaintenence_Click(object sender, EventArgs e)
								{
												Car selectedCar = getCurrentlySelectedCar();

												selectedCar.SetUnderMaintenance(!selectedCar.isUnderMaintenence());
												updateInterface(selectedCar);
								}

								private void btnAddFuel_Click(object sender, EventArgs e)
								{
												int fuelToAdd = Convert.ToInt32(nudFuel.Text);
												Car selectedCar = getCurrentlySelectedCar();

												selectedCar.AddFuel(fuelToAdd);
												updateInterface(selectedCar);
								}

								private void btnSell_Click(object sender, EventArgs e)
								{
												Car selectedCar = getCurrentlySelectedCar();

												selectedCar.SetSold();
												updateInterface(selectedCar);
								}

								private void pbSteer_Click(object sender, EventArgs e)
								{
												int kmDriven = Convert.ToInt32(nudKilomiter.Text);
												Car selectedCar = getCurrentlySelectedCar();

												selectedCar.Drive(kmDriven);
												updateInterface(selectedCar);
								}
				}
}
