using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketOnline.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ticket()
        {
            return View();
        }
        public ActionResult Revenue()
        {
            return View();
        }
    }
}