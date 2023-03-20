using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicektManagement
{
    class Person
    { 
        public string Id{ get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Person(string id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
    }
    class Admin : Person
    {
        public string Email { get; set; }

        public Admin(string id, string name, string email, string phone) : base(id, name, phone)
        {
            Email = email;
        }
        public override string ToString()
        {
            return String.Format(Name + " ; " + Email+ " ; "  );
        }
        private static List<string> seats ;
        private static void AddSeats()
        {
            seats = new List<string>(new string[] { "A1", "A2", "A3", "A4", "B1", "B2", "B3", "B4" });

        }
        List<Route> routes;
        public List<Route> BuildRoutes()
        {
            AddSeats();
            routes = new List<Route>();
            routes.Add(new Route("Dhaka", "KHU", 222, 5));
            return routes;
        }
        List<Bus> buses;
        public List<Bus> AddBus()
        {
            buses = new List<Bus>();
            buses.Add(new Bus("b1", 28, BusType.Business, FuelType.Diesel, seats, routes[0], 1200));
            buses.Add(new Bus("b2", 36, BusType.Economy, FuelType.Diesel, seats, routes[0], 700));
            return buses;
        }
        public Bus GetBus(string busId)
        {
            foreach (Bus bus in buses)
            {
                if (bus.BusId == busId)
                    return bus;
            }
            return null;
        }

    }

    class Customer : Person
    {
        public Customer(string id, string name, string phone) : base(id, name, phone)
        {
        }
        public void ShowAvailableSeats() 
        {
        }
        public string PurchaseTicket(string seatNumber)
        {
            return "purchase successful";
        }
    }
}
