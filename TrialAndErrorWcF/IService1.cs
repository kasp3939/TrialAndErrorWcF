using System.Collections.Generic;
using System.ServiceModel;

namespace TrialAndErrorWcF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Flight> GetData();


        [OperationContract]
        Flight FindFlightByID(int flightNumber);

        [OperationContract]
        string ChangeFlight(int flightNumber,string locationFrom, string locationTo);
    }
}
