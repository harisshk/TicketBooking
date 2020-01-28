using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
    class MovieRepositary
    {
        static int count = 0;
        static bool flag;
        static int value;
        static List<Movie> MovieList = new List<Movie>();

        static MovieRepositary()
        {

            MovieList.Add(new Movie(1, "Darbar", "10:00 AM", 5, 60, 120));
            MovieList.Add(new Movie(2, "Pattasu", "10:30 AM", 2, 50,150));
            

        }
        internal static void AddMovie(Movie movie)
        {
            MovieList.Add(movie);
        }
        internal static void ShowMoives()
        {
            foreach (Movie list in MovieList)
            {
                Console.WriteLine("MovieID: '{0}'  Movie Name: '{1}'Show Time: '{2}'  Screen: '{3}'  Tickets Available: '{4}'  Price: '{5}'", list.MovieId, list.MovieName,list.ShowTime, list.ScreenNumber, list.AvailableTickets, list.TicketPrice);
            }
        }
       
        internal static void DeleteMovie(int deleteItemNo)
        {


            foreach (Movie list in MovieList)
            {
                count++;
                if ((list.MovieId).Equals(deleteItemNo))
                {
                    flag = true;
                    Console.WriteLine("true");
                    value = count - 1;
                    count = 0;
                    break;
                }
            }
            if (flag)
            {
                MovieList.RemoveAt(value);
                flag = false;
            }
            foreach (Movie list in MovieList)
            {
                Console.WriteLine("Items after removal");
                Console.WriteLine("MovieID : '{0}'\nMovie Name : '{1}'\nShow Time : '{2}'\nScreen Number : '{3}'\nNumber of Tickets Available : '{4}'\nPrice Of Ticket : '{5}'", list.MovieId, list.MovieName, list.ShowTime, list.ScreenNumber, list.AvailableTickets, list.TicketPrice);

            }

        }


    }

}
