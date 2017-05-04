using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example.Models
{
    public class GetCountry
    {
        public int Country_Id { get; set; }
        public int State_Id { get; set; }
        public SelectList getlist { get; set; }
        public SelectList getstatelist { get; set; }

    }
}