using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Models
{
    [Table("tbl_PatientInfo")]
    public class MPatientInfocs
    {
       
        [Key]
        public int patid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}