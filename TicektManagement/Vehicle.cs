using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicektManagement
{
    interface IVehicle
    {
        FuelType FuelType { get; }
        string GetLocation();
    }
    
    
    class Bus : IVehicle
    {
        public string BusId { get; set;}
        public int Capacity { get; set; }
        public BusType BusType { get; set; }
        public FuelType FuelType { get; }
        private static List<string> Seats { get; set; }
        public int Fare { get; set; }

        public Route Route { get; set; }

        public Bus(string busId, int capacity, BusType busType, FuelType fuelType, List<string> seats, Route route, int fare)
        {
            BusId = busId;
            Capacity = capacity;
            BusType = busType;
            FuelType = fuelType;
            Seats = seats;
            Route = route;
            Fare = fare;
        }

        
        public bool BookSeats(string seat)
        {
            if (Seats.Contains(seat))
            {
                Seats.Remove(seat);
                return true;
            }
            return false;
            
        }
        public string GetLocation ()
        {
            return "";
        }

        public static List<string> GetSeats()
        { 
            return Seats;
        }
        public override string ToString()
        {
            return string.Format(Route + " ;  total seats : " + Capacity + "  ;  Fare : "+ Fare + " ;  Distance : " + Route.DistanceInKm);
        }
    }
}
