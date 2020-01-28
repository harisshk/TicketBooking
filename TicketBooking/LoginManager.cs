using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
    class LoginManager
    {
        public static string AdminUsername = ConfigurationManager.AppSettings["username"].ToString();
        public static string AdminPassword = ConfigurationManager.AppSettings["password"].ToString();

        public static string session;
        
        public static string password;
        public static void CheckLogin(string username,string password)
        {
            if (CheckAdmin(username, password))
            {
                if (session == "finallogin")
                {
                    session = "logged";
                    Console.WriteLine("Welcome!!! Admin");
                }
                else
                {
                    session = "logged";
                    
                    Admin admin = new Admin();
                }
            }
            else if (Login(username, password))
            {
                UserOperation.Operation();
            }

        }
        internal static bool CheckAdmin(string username, string password)
        {

            if (username == username && password == AdminPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static bool Login(String username, string password)
        {
            string Username = username;
             string Password = password;

            foreach (KeyValuePair<string, UserDetails> key in UserRepository.UserData)
            {
                UserDetails user = (UserDetails)key.Value;
                if (UserRepository.UserData.ContainsKey(Username) && user.Password == Password)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("User Logged In");

                    return true;
                }
                else
                {

                    return false;
                }

            }

            return false;
        }
    }
}
