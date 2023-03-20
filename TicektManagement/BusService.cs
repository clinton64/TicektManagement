using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicektManagement
{
    class BusService
    {
        private static List<string> seats;
        private static List<Route> routes;
        private static List<Bus> buses;
        private static void AddSeats()
        {
            seats = new List<string>(new string[] { "A1", "A2", "A3", "A4", "B1", "B2", "B3", "B4" });

        }
        
        public static List<Route> BuildRoutes()
        {
            AddSeats();
            routes = new List<Route>();
            routes.Add(new Route("Dhaka", "KHU", 222, 5));
            return routes;
        }
        
        public static List<Bus> AddBus()
        {
            buses = new List<Bus>();
            buses.Add(new Bus("b1", 28, BusType.Business, FuelType.Diesel, seats, routes[0], 1200));
            buses.Add(new Bus("b2", 36, BusType.Economy, FuelType.Diesel, seats, routes[0], 700));
            return buses;
        }
        public static Bus GetBus(string busId)
        {
            foreach (Bus bus in buses)
            {
                if (bus.BusId == busId)
                    return bus;
            }
            return null;
        }
    }
}
