using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class WebRequest : List<Browser>
    {
        public WebRequest() { }

        public WebRequest(IEnumerable<Browser> collection) : base(collection)
        {
        }
    }
}