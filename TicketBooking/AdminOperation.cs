using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
    class AdminOperation
    {
        public static void  AdminControl()
        {
            bool count = true;
            byte choice;
            MovieManager movieManager = new MovieManager();
            while (count)
            {
                Console.WriteLine("1.Add Movie Details\n2.Update  Details\n3.View Movies Running\n4.Delete Details\n5.Log out");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
               
                        MovieManager.AddMovie();
                        break;
                    case 2:
                        
                        break;

                    case 3:
                        MovieManager.ShowMovieList();
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        LoginManager.session = "Logged out";
                        count = false;
                        break;
                    default:
                        Console.WriteLine("enter correct number");
                        break;
                }
            }
        }
    }
}
