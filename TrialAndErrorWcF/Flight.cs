using System;
using System.Runtime.Serialization;

namespace TrialAndErrorWcF
{
    [DataContract]
    public class Flight
    {
        [DataMember]
        public int FlightId { get; set; }
        [DataMember]
        public string FlightType { get; set; }
        [DataMember]
        public string FromLocation { get; set; }
        [DataMember]
        public string ToLocation { get; set; }
        [DataMember]
        public DateTime DepartTime { get; set; }
        [DataMember]
        public DateTime ArrivalTime { get; set; }

        public Flight(int _flightid, string _flighttype, string _fromlocation, string _tolocation, DateTime _departtime, DateTime _arrivaltime)
        {
            FlightId = _flightid;
            FlightType = _flighttype;
            FromLocation = _fromlocation;
            ToLocation = _tolocation;
            DepartTime = _departtime;
            ArrivalTime = _arrivaltime;
        }

        public Flight()
        {

        }
    }
}
