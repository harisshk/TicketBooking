using System;


namespace TicketBooking
{
    class UserDetails
    {
        internal string Name { set; get; }
        internal string Password { set; get; }
        internal string PhoneNo { set; get; }
        internal string Email { set; get; }

        internal UserDetails(string password)
        {
            Console.WriteLine("\nEnter your Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your phone No");
            PhoneNo = Console.ReadLine();
            Password = password;
        }

    }
}
