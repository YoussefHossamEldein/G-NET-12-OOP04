using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.MovieTicketSystem
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }  
        public IMAXTicket(bool is3d,string name,decimal price) : base(name, price)
        {
            Is3D = is3d;

            if(Is3D)
            {
                price += 30;
            }
        }
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"| Is 3D : {Is3D}");
        }
    }
}
