using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
        public DateTime SignUpDate { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}