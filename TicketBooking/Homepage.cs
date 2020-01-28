using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
    class Homepage
    {
        static Homepage()
        {
            Console.WriteLine("$$$$$$$$$$$$$$ Welcome To SPI Cinemas  $$$$$$$$$$$$$$");
        }
        public void Show()
        {
            int selection;
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("1.Login\n2.SignUp\n3.Movies\n4.Exit\n\nEnter the number:");
                try
                {
                    selection = int.Parse(Console.ReadLine());
                    switch (selection)
                    {
                        case 1:
                            UserRepository.UserLogin();
                            flag = false;
                            break;
                        case 2:
                            UserRepository.UserSignUp();
                            flag = false;
                            break;
                        case 3:
                            MovieRepositary.ShowMoives();
                            flag = false;
                            break;
                        case 4:
                            Console.WriteLine("4");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Default");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Error input Try Again");
         
                }
            }
        }
    }
}
