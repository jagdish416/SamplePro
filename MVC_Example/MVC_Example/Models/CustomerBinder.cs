using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace MVC_Example.Models
{
    public class CustomerBinder : System.Web.Mvc.IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext
bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;
            string strCustomerName = request.Form.Get("CusName");
            int strCustomerAge =Convert.ToInt32( request.Form.Get("CusAge"));
            Customer cs = new Customer {
                CustomerName = strCustomerName,
                CustomerAge= strCustomerAge
            };
            return cs;
            //return new Customer
            //{
            //    CustomerCode = strCustomerCode,
            //    CustomerName = strCustomerName
            //};
        }
    }
}
