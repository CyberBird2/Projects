using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Agency
    {
        private List<Flight> availableFlights;
        Flight Flights = new Flight();
        

        public Agency()
        {
             availableFlights = new List<Flight>();
           
           
        }

        public void AddFlight(Flight f/*, string flightNo, string destination, int totalSeats, double costPerSeat*/)
        {
            bool exists = false;

            //first check if flight already exists
            foreach (Flight item in availableFlights)
            {
                if (item.GetFlightNo() == f.GetFlightNo()/*flightNo*/)
                {
                
                    //exists will become true only if there really is already a flight with that nr
                    exists = true;

                }
            }

            //if the flight does not exist yet then add it
            if (!exists && f.GetTotalSeatCount() > 0)
            {
                //do adding
                availableFlights.Add(f);
                
            }
        }

        public void BookSeat(string FlightNo)
        {
            foreach (Flight item in availableFlights)
            {
                if (item.GetFlightNo() == FlightNo && !item.FullyBooked())
                {
                    item.BookSeat();
                }
            }
        }

        public Flight[] GetAvailableFlights()
        {
            
            List<Flight> available  = new List<Flight>();
            
            foreach (Flight item in availableFlights)
            {
                if (!item.FullyBooked())
                {
                    available.Add(item);
                }
            }
            return available.ToArray();
        }
        

        public Flight[] GetFullFlights()
        {
        
            List<Flight> booked = new List<Flight>();
            
            foreach (Flight item in availableFlights)
            {
                if (item.FullyBooked())
                {
                    booked.Add(item);
                }
            }
            return booked.ToArray();
        }
        public string GetProfitOverview()
        {
            string info = "";
            foreach (Flight item in availableFlights)
            {
                Flights = item;

                
                info = "There are " + Flights.GetTotalSeatCount() + " seats in total "
                     + Flights.GetBookedSeatCount() + " seats have been booked so far " +
                    "Total cost for seats: $ " + Flights.TotalCostForSeat() + " Profit : $ " +
                    Flights.GetCalculateProfit();
            }

            return info;
        }
        

       
    }
}
