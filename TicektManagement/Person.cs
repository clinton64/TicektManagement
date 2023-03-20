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
