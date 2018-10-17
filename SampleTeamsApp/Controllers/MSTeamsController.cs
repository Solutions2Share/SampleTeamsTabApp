using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleTeamsApp.Controllers
{
    public class MSTeamsController : Controller
    {
        // GET: MSTeams
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Configuration()
        {
            return View();
        }
    }
}