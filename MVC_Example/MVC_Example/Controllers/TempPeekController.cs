using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace MVC_Example.Controllers
{

    public class TempPeekController : Controller
    {
        // GET: TempPeek
        public ActionResult Index()
        {
            return View();
        }
    }
}