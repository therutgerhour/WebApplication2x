using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DataAccess;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class WebRequestController : Controller
    {
        // GET: BrowserClient
        public ActionResult Index()
        {
            var api = new LitmusAPI();
            var clients = api.GetListOfClients();

            return View(clients.Result);
        }
    }
}