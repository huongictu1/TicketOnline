using TicketOnline.Domain;
using TicketOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketOnline.Controllers
{
    public class NavbarController : Controller
    {
        // GET: Navbar
        public ActionResult Index()
        {
            var data = new TicketOnline.Domain.Data();
            return PartialView("_Navbar", data.navbarItems().ToList());
        }
    }
}