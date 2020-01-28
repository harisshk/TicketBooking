using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
    class Movie
    {
        internal int MovieId { get; set; }
        internal string MovieName { get; set; }
        internal string ShowTime { get; set; }
        internal int ScreenNumber { get; set; }
        internal double TicketPrice { get; set; }
        internal int AvailableTickets { get; set; }

        internal Movie(int movieId, string movieName, string showTime, int screenNumber, int availableTickets, double ticketPrice)
        {
            this.MovieName = movieName;
            this.AvailableTickets = availableTickets;
            this.TicketPrice = ticketPrice;
            this.MovieId = movieId;
            this.ScreenNumber = screenNumber;
            this.ShowTime = showTime;
        }
        

    }
}
