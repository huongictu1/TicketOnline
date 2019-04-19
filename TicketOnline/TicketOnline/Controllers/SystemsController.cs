using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketOnline.Controllers
{
    public class SystemsController : Controller
    {
        // GET: Systems
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BackUp()
        {
            return View();
        }
        public ActionResult ResetPassword()
        {
            return View();
        }
    }
}