using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Example
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Application["NoVistor"] = 0;
           
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
           public  void session_start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["NoVistor"] = (int)(Application["NoVistor"]) + 1;
            Application.UnLock();
        }
    }
}
