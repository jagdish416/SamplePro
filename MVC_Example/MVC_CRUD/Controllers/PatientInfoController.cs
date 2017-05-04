using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD.Models;
using System.Runtime.InteropServices;

namespace MVC_CRUD.Controllers
{
    public class PatientInfoController : Controller
    {
        MpatientInfoContext objpat = new MpatientInfoContext();
        // GET: PatientInfo
        public ActionResult Index()
        {
           List<MPatientInfocs> mpati = objpat.patientinfo.ToList();
          // MPatientInfocs mpati=   objpat.patientinfo.Single(e => e.patid == id);
            return View(mpati);
        }
      [ValidateInput(false)]
        public ActionResult Details(int id,[Optional] int i)
        {
           MPatientInfocs pat= objpat.patientinfo.Single(e => e.patid==id);
            return View(pat);
        }
    }
}