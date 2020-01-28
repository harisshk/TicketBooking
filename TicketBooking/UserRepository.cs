using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
    class UserRepository
    {
        public static Dictionary<string, UserDetails> UserData = new Dictionary<string, UserDetails>();
        static string Username { set; get; }
        private static string Password { set; get; }



        public static void UserLogin()
        {
            string username;
            string password = null;
            Console.WriteLine("Enter Username");
            username = Console.ReadLine();
            Console.WriteLine("Enter password");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace will Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password.Substring(0, (password.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            while (true);
            LoginManager.CheckLogin(username, password);
        }
        internal static void UserSignUp()
        {
            bool flag = true;
            Console.WriteLine("Sign-up");
            while (flag == true)
            {
                Console.WriteLine("Enter Email Id to continue");
                Username = Console.ReadLine();
                if (Validation.isValidEmail(Username))
                {
                    string password = null;
                    Console.WriteLine("Enter new Password : ");
                    do
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        // Backspace will Not Work
                        if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                        {
                            Password += key.KeyChar;
                            Console.Write("*");
                        }
                        else
                        {
                            if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                            {
                                password = password.Substring(0, (password.Length - 1));
                                Console.Write("\b \b");
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    while (true);
                    Password = password;

                    UserData.Add(Username, new UserDetails(password));
                    flag = false;
                    Console.WriteLine("\nLog in to Continue...");
                    Homepage home = new Homepage();
                    home.Show();
                }
                else
                {
                    Console.WriteLine("Email is Invalid...\nTry Again\n");
                }
            }
        }
    }
}
