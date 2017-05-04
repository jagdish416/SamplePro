using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.Models
{
    public class Emp
    {
        [DataType(DataType.Url)]
        [Required]
        [Display (Name ="Employee Id:")]
        public int emp_id { get; set; }
        [Display (Name ="EmployeeName :")]
        public string emp_name { get; set; }
        [Display (Name ="Gender :")]
        public string gender { get; set; }
        [Display (Name ="Age :")]
        public int age { get; set; }
        [Required]
        [Display (Name ="Address :")]
        public string address1 { get; set; }
        [Display (Name ="Country :")]
        public string country { get; set; }
        [Required]
        [Display (Name ="Phone Number :")]
        public long phone_number { get; set; }
        public List<checkboxes> check { get; set; }
       
       
    }
    public class checkboxes
    {
        public string Text { get; set; }
        [Display(Name = "Intrested :")]
        public bool intrested { get; set; }
    }
}