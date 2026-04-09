using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.MovieTicketSystem
{
    internal class Cinema 
    {
        private Ticket[] _tickets = new Ticket[20];
        public string Name { get; set; }
        Projector projector = new Projector();

        public Cinema(string name)
        {
            Name = name;
        }

        public void AddTicket(Ticket t)
        {
           for(int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    return;
                }
            }
        }
        public void PrintAllTickets()
        {
         foreach(var ticket in _tickets)
            {
                if(ticket != null)
                {

                ticket.PrintTicket();
                }
            }
        }
        public void OpenCinema()
        {
            Console.WriteLine("========= Cinema Opened =========");
            projector.Start();
        }
        public void CloseCinema()
        {
            Console.WriteLine("========= Cinema Closed =========");
            projector.Stop();
        }
    }

}
