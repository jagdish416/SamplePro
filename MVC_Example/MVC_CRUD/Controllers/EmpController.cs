using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD.DAL;
using MVC_CRUD.Models;
using System.Collections;

namespace MVC_CRUD.Controllers
{
    public class EmpController : Controller
    {
        DEmp objdemp = new DEmp();

        // GET: Emp

        public ActionResult Details()
        {
            MPatientInfocs objpatinfo = new MPatientInfocs()
            {
                Name = "Jagdish",
                Address = "Secnderabad"
            };

            List<MPatientInfocs> objpatientinfo1 = new List<MPatientInfocs>();
            objpatientinfo1.Add(new MPatientInfocs { Name = "Sai", Address = "Namalagundu" });
            objpatientinfo1.Add(new MPatientInfocs { Name = "Arun", Address = "ECIL" });

            return View(objpatientinfo1.ToList());
        }
        public string Index(string id)
        {

            return "Welcome to Callhealth" + id + " Query string is" + Request.QueryString["name"];
        }
        public ActionResult Index1()
        {
            ViewData["countries"] = new List<string>()
            {
                "USA",
                "India",
                "Dubai"
            };

            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            Emp model = new Emp();

            model.check = new List<checkboxes>
    {
        new checkboxes { Text = "Fulltime" },
        new checkboxes { Text = "Partly" },
        new checkboxes { Text = "Contract" }
    };

            return View(model);

        }
        [HttpPost]
        public ActionResult Create(Emp objmodel)
        {

            int emp_id = objmodel.emp_id;
            string emp_name = objmodel.emp_name;
            string gender = objmodel.gender;
            int age = objmodel.age;
            string add = objmodel.address1;
            string coun = objmodel.country;
            long phoneno = objmodel.phone_number;
            string result = "";
            foreach (var jag in objmodel.check)
            {
                if (jag.intrested)
                {
                    result += jag.Text + ",";
                }
            }

            objdemp.Emp_Insert(0, emp_id, emp_name, gender, age, add, coun, phoneno, result);
            return View();
        }

        [HttpGet]
        public ActionResult Select()
        {
            //DataSet emp = objdemp.Select(1);
            //return View(emp.Tables[0].AsEnumerable().ToList());
            DEmp objdemp = new DEmp();
            DataTable dtemp = objdemp.Select(1).Tables[0];
            IEnumerable<Emp> emplist = dtemp.AsEnumerable().Select(row => new Emp
            {
                emp_id = Convert.ToInt16(row["Emp_id"]),
                emp_name = row["Emp_Name"].ToString(),
                gender = row["Gender"].ToString(),
                age = Convert.ToInt32(row["Age"]),
                address1 = row["Address1"].ToString(),
                country = row["Country"].ToString(),
                phone_number = Convert.ToInt64(row["Phone_No"]),

                check = splitcheckboxes(row["Intrested"].ToString())
            }).ToList();
            return View(emplist);
        }
        public List<checkboxes> splitcheckboxes(string rowcheck)
        {
            List<checkboxes> objcheck = new List<checkboxes>();
            string[] listcheck = rowcheck.ToString().Split(',');
            for (int i = 0; i < listcheck.Length; i++)
            {
                objcheck.Add(new checkboxes { Text = listcheck[i].ToString() });
            }
            return objcheck;
        }
    }
}