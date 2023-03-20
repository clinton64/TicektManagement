using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicektManagement
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("******welcome to the Online Ticket System*******");
            Console.WriteLine("\t Available Buses");
            Admin admin = new Admin("10", " clinton", "xyz@gmail.com", "4726");
            BusService.BuildRoutes();
            List<Bus> buses = BusService.AddBus();
            List<string> busIds = new List<string>();
            foreach (Bus bs in buses)
            {
                Console.WriteLine(bs.BusId + " ; " + bs.ToString());
                busIds.Add(bs.BusId);
            }

        readBusId:
            Console.Write("Select a BusId : ");
            String busId = Console.ReadLine();
            if (!busIds.Contains(busId))
                goto readBusId;

            Bus bus = BusService.GetBus(busId);
            List<string> seats = Bus.GetSeats();
            Console.WriteLine("Available Seats : \n");
            ViewSeats(seats);

        readSeatId:
            Console.Write("\nSelect seat number : ");
            String seatId = Console.ReadLine();
            if (!seats.Contains(seatId))
                goto readSeatId;
       
            TicketProcess(bus,seatId);
            Console.ReadLine();
        }

        private static void ViewSeats(List<string> seats)
        {
            foreach (string seat in seats)
            {
                Console.Write(seat + " ");
            }
        }

        private static void TicketProcess(Bus bus, string seatId)
        {
            Console.WriteLine("\nBooking in Processs.....");
            Console.Write("Provide your Name Please : ");
            String name = Console.ReadLine();
            Console.Write("Provide your phone number Please : ");
            String phone = Console.ReadLine();
            Ticket ticket = new Ticket(bus.Route, bus, DateTime.Today, new Customer("1", name, phone), seatId, "Kamalapur");
            ticket.printTicket();
        }
    }
}
