using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicektManagement
{
    class Ticket
    {
        public Route Route { get; set; }
        public Bus Bus { get; set; }
        public DateTime JourneyDate { get; set; }
        public Person Person { get; set; }
        public string Seat { get; set; }
        public string BoardingPoint { get; set; }

        public Ticket(Route route, Bus bus, DateTime journeyDate, Person person, string seat, string boardingPoint)
        {
            Route = route;
            Bus = bus;
            JourneyDate = journeyDate;
            this.Person = person;
            Seat = seat;
            BoardingPoint = boardingPoint;
        }

        public void printTicket()
        {
            Console.WriteLine("\n\n***Ticket purchase Successful***");
            Console.WriteLine("From : " + Route.Source + " \t To : " + Route.Destination);
            Console.WriteLine("Bus Information : " + Bus);
            Console.WriteLine("Seat Number : " + Seat);
            Console.WriteLine("Departure Date : " + JourneyDate.ToShortDateString() + "\nDeparture Time : " + JourneyDate.TimeOfDay);
            Console.WriteLine("Boarding point : " + BoardingPoint);
            Console.WriteLine("Passenger Name : " + Person.Name  + "\nPhone : " + Person.Phone);
            PrintSpaces();
        }
        private static void PrintSpaces()
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("");
            }
        }
    }
}
