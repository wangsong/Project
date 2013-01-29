using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMusic.Models
{
    public class Songer
    {
        public int SongerID { get; set; }

        public string Name { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
        public string Birthplace { get; set; }
        public DateTime Birthdate { get; set; }
    }
}