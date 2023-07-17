using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWeb.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public Roles Role { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }

        public User()
        {
            // Empty constructor
        }
      
        public User(int userId, string username, string passwordHash, Roles role, string email, string fullName)
        {
            UserId = userId;
            Username = username;
            PasswordHash = passwordHash;
            Role = role;
            Email = email;
            FullName = fullName;
        }
    }
}
