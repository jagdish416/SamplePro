using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Example.Models;
using System.Security.Policy;

namespace MVC_Example.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("Jagdish/Customer")]
        public ActionResult Index([ModelBinder(typeof(CustomerBinder))]Customer obj)
        {
            int a = 1111;

            // string a = System.Web.HttpContext.Current.Application["NoVistor"].ToString();
            System.Web.HttpContext.Current.Application["NoVistor"] = (int)(System.Web.HttpContext.Current.Application["NoVistor"]) + 1;
            ViewBag.Vistors = System.Web.HttpContext.Current.Application["NoVistor"];
            ViewData["Ja"] = System.Web.HttpContext.Current.Application["NoVistor"];
            //ViewBag.Vistors = a;
           
            ViewData["khjkhkj"] = a;
            ViewBag.aa = a;
            TempData["prasa"] = a;
            TempData.Keep("prasa");
            return View();

        }
        
    }
}