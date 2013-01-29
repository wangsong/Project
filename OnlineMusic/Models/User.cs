using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMusic.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}