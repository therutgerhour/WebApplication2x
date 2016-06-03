using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Email
    {
        public string name { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string average_time { get; set; }
        public Message message { get; set; }
    }
}