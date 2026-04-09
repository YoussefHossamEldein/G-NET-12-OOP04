using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.MovieTicketSystem
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee = 50;
        public VIPTicket(bool lounge,string name,decimal price) : base(name, price)
        {
            LoungeAccess = lounge;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"| Lounge Access : {LoungeAccess} | Service Fee {ServiceFee}");
        }


    }
}
