using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{

    class MovieManager
    {

       
        internal static void AddMovie()
        {

            Console.WriteLine("Enter Movie Id:");
            int movieId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Movie name :");
            string movieName = Console.ReadLine();
            Console.WriteLine("Enter Show Time: ");
            string showTime = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Screen Number: ");
            int screenNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of tickets available: ");
            byte availableTickets = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticket Price: ");
            double ticketPrice = double.Parse(Console.ReadLine());

            MovieRepositary.AddMovie(new Movie(movieId, movieName, showTime, screenNumber, availableTickets, ticketPrice));
        }
        internal static void ShowMovieList()
        {
            MovieRepositary.ShowMoives();
        }
        internal static bool PaymentLogin()
        {
            Console.WriteLine("1.Login\n2.Signup");
            byte choice = byte.Parse(Console.ReadLine());
            if (choice == 1)
            {
                UserRepository.UserLogin();
                return true;
            }
            else if (choice == 2)
            {
                UserRepository.UserSignUp();
                Console.WriteLine("Login to continue");
                UserRepository.UserLogin();
                return true;

            }
            else
                Console.WriteLine("Enter correct no");
            return false;
        }
    }
}
