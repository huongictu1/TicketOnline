using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketOnline.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Employee()
        {
            return View();
        }
        public ActionResult Customer()
        {
            return View();
        }
        public ActionResult Cinema()
        {
            return View();
        }
        public ActionResult Role()
        {
            return View();
        }
        public ActionResult TicketType()
        {
            return View();
        }
        public ActionResult TimeFrame()
        {
            return View();
        }
    }
}