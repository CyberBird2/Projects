using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._1___Car
{
				class Car
				{
								private int maxFluelLevel;
								private string licensePlate;
								private double fuelEfficiency;
								private double currentFuelLevel;
								private carStatusModes carStatus;

								public enum carStatusModes { OK, UNDER_MAINTENENCE, SOLD };

								public Car(string nwLicensePlate, int nwMaxFluelLevel, double nwFuelEfficiency)
								{
												carStatus = carStatusModes.OK;
												currentFuelLevel = 0.0;

												fuelEfficiency = nwFuelEfficiency;
												maxFluelLevel = nwMaxFluelLevel;
												licensePlate = nwLicensePlate;
								}

								public void AddFuel(int fuel)
								{
												if (carStatus != carStatusModes.SOLD)
												{
																if (fuel > 0)
																{
																				if (currentFuelLevel + fuel <= maxFluelLevel)
																								currentFuelLevel += fuel;
																				else
																								currentFuelLevel = maxFluelLevel;
																}
												}
								}

								public string GetLicensePlate()
								{
												return licensePlate;
								}

								public bool isUnderMaintenence()
								{
												return (carStatus == carStatusModes.UNDER_MAINTENENCE);
								}

								public void SetUnderMaintenance(bool isUnderMaintencence)
								{
												if (isUnderMaintencence)
												{
																if (carStatus == carStatusModes.OK)
																				carStatus = carStatusModes.UNDER_MAINTENENCE;
												} else
												{
																carStatus = carStatusModes.OK;
												}
								}

								public void SetSold()
								{
												if (carStatus == carStatusModes.OK)
																carStatus = carStatusModes.SOLD;
								}

								public string GetInfo()
								{
												//< license plate > -status: < car status >, fuel: < current fuel level> / < max fuellevel >
												return $"{licensePlate} - status:{carStatus.ToString()}, fuel:{currentFuelLevel.ToString("0.##")}/{maxFluelLevel}, eff:{fuelEfficiency.ToString("0.##")}";
								}

								public void Drive(int kmDriven)
								{
												double fuelToRemove = (kmDriven * fuelEfficiency);

												if (currentFuelLevel > 0)
												{
																if (fuelToRemove > 0)
																{
																				if (currentFuelLevel - fuelToRemove > 0)
																								currentFuelLevel -= fuelToRemove;
																				else
																								currentFuelLevel = 0.0;
																}
												}
								}
				}
}
