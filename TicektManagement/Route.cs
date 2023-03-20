using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicektManagement
{
    class Route
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public float DistanceInKm { get; set; }
        public int ApproxTimeRequiredHrs { get; set; }

        public Route(string source, string destination, float distanceInKm, int approxTimeRequiredHrs)
        {
            Source = source;
            Destination = destination;
            DistanceInKm = distanceInKm;
            
            ApproxTimeRequiredHrs = approxTimeRequiredHrs;
        }

        public override string ToString()
        {
            return string.Format(Source + "-" + Destination);
        }
    }
    enum BusType
    {
        Economy = 1,
        Business = 2
    };
    enum FuelType
    {
        Diesel = 1,
        Petrol = 2,
        Octane = 3
    };
}
