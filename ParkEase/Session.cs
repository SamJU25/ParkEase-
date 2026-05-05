using System;

namespace ParkEase
{
    // stores logged in user info
    public static class Session
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
       
    }
}
