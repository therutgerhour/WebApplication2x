using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BrowserClients : List<Browser>
    {
        public BrowserClients() { }

        public BrowserClients(IEnumerable<Browser> collection) : base(collection)
        {
        }
    }
}