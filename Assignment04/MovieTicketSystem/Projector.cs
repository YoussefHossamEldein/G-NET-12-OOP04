using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment04.MovieTicketSystem
{
    internal class Projector
    {
        public void Start() => Console.WriteLine("Projector Started");
        public void Stop() => Console.WriteLine("Projector Stopped");
    }
}
