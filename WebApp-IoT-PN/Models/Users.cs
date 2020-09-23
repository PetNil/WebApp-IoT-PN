using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_IoT_PN.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool FirstLogon { get; set; }

        public static List<Users> listOfAdmin = new List<Users>();

        public static void GenerateAdmin()
        {
            listOfAdmin.Add(new Users { Id = 1, Email = "admin@domain.com", Password = "BygMig123!", Role = "Admin" });
        }
    }
}
