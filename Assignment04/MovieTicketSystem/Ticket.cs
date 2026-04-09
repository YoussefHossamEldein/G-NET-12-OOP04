using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.MovieTicketSystem
{
    internal class Ticket
    {
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        private static int TicketId;

        public Ticket(string moviename,decimal price)
        {
            MovieName = moviename;
            Price = price;
            TicketId++;
        }
        public decimal PriceAfterTax => Price + (Price * 0.14m);
        public static int GetTotalTickets() => TicketId;
            
        public virtual void PrintTicket()
        {
            Console.WriteLine("========= All Tickets =========");
            Console.WriteLine($"Ticket Id : {TicketId} | Movie Name : {MovieName} | Price : {Price} | After Tax : {PriceAfterTax}");
        }
        public void SetPrice(decimal price)
        {
            Price = price;
        }
        public void SetPrice(decimal basePrice, decimal Multiplier)
        {
            Price = basePrice * Multiplier;
        }



            }
}
