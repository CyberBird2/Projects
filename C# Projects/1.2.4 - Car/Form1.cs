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
				/* I used lists in this exercise. This wasn't what was in the reader, but what's in the reader sucks... */

				public partial class Form1 : Form
				{
								private List<Car> cars;
								private Random r;

								public Form1()
								{
												InitializeComponent();
												r = new Random();

												// Init cars
												cars = new List<Car>();
												addCar("Car 1", 50, .2, false);
												cbCar.SelectedIndex = 0;
												updateInterface(null);
								}
								
								private void addCar(string licenceplate, int maxFuelLevel, double fuelEfficiency, bool setUnderMaintenance)
								{
												Car newCar = new Car(licenceplate, maxFuelLevel, fuelEfficiency);

												newCar.SetUnderMaintenance(setUnderMaintenance);
												cars.Add(newCar);
												// Update list
												cbCar.Items.Add(newCar.GetLicensePlate());
								}

								private Car getCurrentlySelectedCar()
								{
												if (cbCar.SelectedIndex > -1)
																return cars[cbCar.SelectedIndex];
												else
																return null;
								}

								private void updateInterface(Car selectedCar)
								{
												if (selectedCar == null)
																selectedCar = getCurrentlySelectedCar();

												if (selectedCar != null)
																lblStatus.Text = selectedCar.GetInfo();
								}

								private void cbCar_SelectedIndexChanged(object sender, EventArgs e)
								{
												updateInterface(null);
								}

								private void btnMaintenence_Click(object sender, EventArgs e)
								{
												Car selectedCar = getCurrentlySelectedCar();

												if (selectedCar != null)
												{
																selectedCar.SetUnderMaintenance(!selectedCar.isUnderMaintenence());
																updateInterface(selectedCar);
												}
								}

								private void btnAddFuel_Click(object sender, EventArgs e)
								{
												int fuelToAdd = Convert.ToInt32(nudFuel.Text);
												Car selectedCar = getCurrentlySelectedCar();

												if (selectedCar != null)
												{
																selectedCar.AddFuel(fuelToAdd);
																updateInterface(selectedCar);
												}
								}

								private void btnSell_Click(object sender, EventArgs e)
								{
												Car selectedCar = getCurrentlySelectedCar();

												if (selectedCar != null)
												{
																selectedCar.SetSold();
																updateInterface(selectedCar);
												}
								}

								private void pbSteer_Click(object sender, EventArgs e)
								{
												int kmDriven = Convert.ToInt32(nudKilomiter.Text);
												Car selectedCar = getCurrentlySelectedCar();

												if (selectedCar != null)
												{
																selectedCar.Drive(kmDriven);
																updateInterface(selectedCar);
												}
								}

								private void btnAddCar_Click(object sender, EventArgs e)
								{
												int maxFuelLevel = Convert.ToInt32(nudFuelLevel.Text);
												string licencePlate = tbLicence.Text.Trim();

												if (licencePlate.Length > 0 && maxFuelLevel > 0)
												{
																addCar(licencePlate, maxFuelLevel, r.NextDouble(), true);
																nudFuelLevel.Text = "";
																tbLicence.Text = "";
												}
								}
				}
}
