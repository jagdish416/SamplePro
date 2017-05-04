using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;
using MVC_Example.Models;

namespace MVC_Example.Controllers
{
    public class DisplayCountry_ListController : Controller
    {
        string con = ConfigurationManager.ConnectionStrings["Con_DB"].ToString();
        // GET: DisplayCountry_List
        public ActionResult Index()
        {
            GetCountry getcountries = new GetCountry();
            //List<Country_States> obj_countrylist = new List<Country_States>();

            con = ConfigurationManager.ConnectionStrings["Con_DB"].ToString();
            string sp_name = "usp_Get_CountryList";
            SqlParameter[] Parameters = new SqlParameter[2];
            Parameters[0] = new SqlParameter("@Country_Id", SqlDbType.Int);
            Parameters[0].Value = System.Data.SqlTypes.SqlInt32.Null;
            Parameters[1] = new SqlParameter("@N_type", SqlDbType.Int);
            Parameters[1].Value = 2;
            DataTable dt = SqlHelper.ExecuteDataset(con,CommandType.StoredProcedure,sp_name,Parameters).Tables[0];
            getcountries.getlist =new SelectList(GetList(dt),"Value","Text");
            //foreach (DataRow item in dt.Rows)
            //{
            //    obj_countrylist.Add(new Country_States { Country_Id = Convert.ToInt32(item["Country_Id"]), Country_Name = item["country_name"].ToString() });

            //}
            // var list = from t in dt select new Country_States{ obj_countrylist.Country_Name = t.country_name, obj_countrylist.Country_Id = t.COuntry_Id }
            return View(getcountries);
        }


        public List<SelectListItem> GetList(DataTable dt)
        {
            var Listtype = (from DataRow r in dt.Rows
                            select new SelectListItem
                            {
                            Value=r["Country_Id"].ToString(),
                            Text=r["country_name"].ToString()
                            }).ToList();
            return Listtype;
        }
        public JsonResult Display(int id)
        {
            string sp_name = "usp_Get_CountryList";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Country_Id", SqlDbType.Int);
            parameters[0].Value = id;
            parameters[1] = new SqlParameter("@N_type", SqlDbType.Int);
            parameters[1].Value = 1;
            DataTable dt = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, sp_name, parameters).Tables[0];
            GetCountry objGetcountry = new GetCountry();
            objGetcountry.getstatelist = new SelectList(GetStatelist(dt), "Value", "Text");
            return Json(objGetcountry.getstatelist, JsonRequestBehavior.AllowGet);
        }
        public List<SelectListItem> GetStatelist(DataTable dt)
        {
            var list = (from DataRow dr in dt.Rows
                        select new SelectListItem
                        {
                            Value = dr["state_id"].ToString(),
                            Text = dr["state_name"].ToString()
                        }).ToList();
            return list;
        }
    }

}