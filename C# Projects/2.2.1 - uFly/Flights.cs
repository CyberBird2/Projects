using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1___uFly
{
				class Agency
				{
								private List<Flight> flights;

								public Agency()
								{
												flights = new List<Flight>();
								}

								public void AddFlight(Flight f)
								{
												if (f.GetTotalSeats() > 0)
																flights.Add(f);
								}

								public void BookSeat(string flightNo)
								{
												foreach (Flight f in flights)
												{
																if (f.GetFlightNo() == flightNo)
																				f.BookSeat();
												}
								}

								public Flight[] GetAvailableFlights()
								{
												return flights.FindAll(item => item.GetAvailableSeats() > 0).ToArray();
								}

								public Flight[] GetFullFlights()
								{
												return flights.FindAll(item => item.GetAvailableSeats() <= 0).ToArray();
								}

								public string GetProfitOverview()
								{
												double totalBookedSeatsCost = 0;
												double totalSeatCost = 0;
												int bookedSeats = 0;
												int totalSeats = 0;

												foreach (Flight f in flights)
												{
																bookedSeats += f.GetBookedSeats();
																totalSeats += f.GetTotalSeats();

																totalBookedSeatsCost += f.GetBookedSeats() * f.GetCostPerSeat();
																totalSeatCost += f.GetCostPerSeat() * f.GetTotalSeats();
												}

												return $"There are {totalSeats} seats in total\n" +
																$"{bookedSeats} seats have been booked so far\n" +
																$"Total costs for seats: € {totalSeatCost}\n" +
																$"Total booked seats: € {totalBookedSeatsCost}\n" +
																$"\tProfit: € {totalBookedSeatsCost - totalSeatCost}";
								}

								internal int GetFLightAmount()
								{
												return flights.Count;
								}
				}

				class Flight
				{
								private int bookedSeatCount;
								private double costPerSeat;
								private int totalSeatCount;
								private string flightNo;
								private string dest;

								public Flight(string _flightNo, string destination, int totalSeats, double _costPerSeat)
								{
												totalSeatCount = totalSeats;
												costPerSeat = _costPerSeat;
												flightNo = _flightNo;
												bookedSeatCount = 0;
												dest = destination;
								}

								public void BookSeat()
								{
												if (bookedSeatCount < totalSeatCount)
																bookedSeatCount++;
								}

								public void BookSeat(int amount)
								{
												if (amount > 0)
												{
																while (amount > 0 && GetAvailableSeats() > 0)
																{
																				BookSeat();
																				amount--;
																}
												}
								}

								public int GetTotalSeats()
								{
												return totalSeatCount;
								}

								public string GetFlightNo()
								{
												return flightNo;
								}

								public double GetCostPerSeat()
								{
												return costPerSeat;
								}

								public int GetBookedSeats()
								{
												return bookedSeatCount;
								}

								public int GetAvailableSeats()
								{
												return totalSeatCount - bookedSeatCount;
								}

								public string GetInfo()
								{
												throw new NotImplementedException();
								}

								public string GetDestination()
								{
												return dest;
								}
				}
}
