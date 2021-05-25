using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Flight
    {
        private string flightNo;
        private string destination;
        private int totalSeatCount;
        private int bookedSeatCount;
        private double costPerSeat;

        
        public Flight() { }
        public Flight(string flightNo, string destination, int totalSeats, double costPerSeat)
        {
            this.flightNo = flightNo;
            this.destination = destination;
            this.totalSeatCount = totalSeats;
            this.bookedSeatCount = 0;
            this.costPerSeat = costPerSeat;
        }

        public void BookSeat()
        {
            bookedSeatCount += 1;
           
        }

        public double GetCostPerSeat()
        {
            return this.costPerSeat;
        }
        public double CalculateCostPerSeat()
        {
            double cost;

            cost = GetCostPerSeat() * GetBookedSeatCount();

            return cost;

        }
        public double TotalCostForSeat()
        {
            double cost;
            cost = GetCostPerSeat() * GetBookedSeatCount();
            return cost;
        }
        public double GetCalculateProfit()
        {
            double profit;
            profit = TotalCostForSeat() - CalculateCostPerSeat();

            return profit;
        }
        public string GetInfo()
        {
            string info = flightNo + " To " + destination + " Has " + GetBookedSeatCount() + "/" + totalSeatCount + " Seats Remaining For $ " + costPerSeat + " Per Seat";
            string infoFullyBooked = flightNo + " To " + destination + " Has " + totalSeatCount + " Booked Seats For $ " + costPerSeat + " Per Seat ";

            if (totalSeatCount == bookedSeatCount)
            {
                return infoFullyBooked;
            }
            else
            {
                return info;
            }
        }

        public bool FullyBooked()
        {
            if (totalSeatCount == bookedSeatCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetFlightNo()
        {
            return this.flightNo;
        }

        public int GetTotalSeatCount()
        {
            return totalSeatCount;
        }

        public int GetBookedSeatCount()
        {
            return bookedSeatCount;
        }
    }
}
