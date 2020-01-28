using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Homepage home = new Homepage();
            home.Show();
            Console.ReadKey();
        }
    }
}