using System;

namespace ParkEase
{
    // stores logged in user info globally
    public static class Session
    {
        public static int UserId { get; set; } // logged in user id
        public static string Username { get; set; } // logged in username
        public static string Role { get; set; } // Admin or User
       
    }
}
