using System;
using System.Collections.Generic;
using System.Linq;

namespace TrialAndErrorWcF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<Flight> listOfFlight = new List<Flight>();
        public object myLock = new object();

        Flight A = new Flight { FlightId = 1, FlightType = "130", FromLocation = "Copenhagen", ToLocation = "Berlin", DepartTime = DateTime.Today.AddDays(1), ArrivalTime = DateTime.Today.AddDays(2) };
        Flight B = new Flight { FlightId = 2, FlightType = "130", FromLocation = "Berlin", ToLocation = "Copgenhagen", DepartTime = DateTime.Today.AddDays(3), ArrivalTime = DateTime.Today.AddDays(4) };
        Flight C = new Flight { FlightId = 3, FlightType = "130", FromLocation = "Copenhagen", ToLocation = "Madrid", DepartTime = DateTime.Today.AddDays(5), ArrivalTime = DateTime.Today.AddDays(6) };

        public void Add(Flight flight)
        {
            listOfFlight.Add(flight);
        }

        public void PopulateList()
        {
            listOfFlight.Add(A);
            listOfFlight.Add(B);
            listOfFlight.Add(C);
        }
        public Flight FindFlightByID(int flightNumber)
        {
                PopulateList();
                Flight _flight = new Flight();
                _flight = null;
                foreach (Flight nFlight in listOfFlight)
                {
                    if (nFlight.FlightId == flightNumber)
                    {
                        _flight = nFlight;
                    }

                }
                return _flight;
        }

        public string ChangeFlight(int _flightNumber, string fromLocation, string toLocation)
        {
            string message = "";
            Flight flight = FindFlightByID(_flightNumber);
            lock (myLock)
            {
                if (flight != null)
                {
                    flight.FromLocation = fromLocation;
                    flight.ToLocation = toLocation;
                    message = "Your flight has been changed";
                }
                else
                {
                    message = "The flight has not found";
                }
            }
            return message;

        }

        public List<Flight> GetData()
        {
            PopulateList();
            return listOfFlight.ToList();
        }
    }
}
