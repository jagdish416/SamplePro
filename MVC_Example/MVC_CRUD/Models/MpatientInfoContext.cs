using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Models
{
    public class MpatientInfoContext:DbContext
    {
        public DbSet<MPatientInfocs> patientinfo { get; set; }
    }
}