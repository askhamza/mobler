using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mobler.Controllers
{
    public class VisiteurController : Controller
    {
        [Route("/acceuil")]
        public ActionResult Index()
        {
            return View();
        }

    }
}