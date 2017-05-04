using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example.Controllers
{
    public class TempkeepController : Controller
    {
        // GET: Tempkeep
        public ActionResult Index()
        {
            string str = TempData["prasa"].ToString();
            List<int> Value = new List<int>() {1,2,3,4 };
            Value.OrderByDescending(p => p);
           

           
           // Value.Remove(0);
            int max = Value[0];
            for(int i=1;i<Value.Count;i++)
            {
                
            }

            return View();
        }

    }
}