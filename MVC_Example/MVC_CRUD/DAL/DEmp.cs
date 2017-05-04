using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MVC_CRUD.DAL
{
    public class DEmp
    {
        string con = ConfigurationManager.ConnectionStrings["DB_Emp"].ConnectionString;
        string sp = string.Empty;
        public int Emp_Insert(int status, int empid, string empname, string gender, int age, string add, string country, long phoneno, string intrested)
        {
            sp = "SP_HIMS_EMP_DETAILS";
            SqlParameter[] parm = new SqlParameter[9];
            parm[0] = new SqlParameter("@STATUS", System.Data.SqlDbType.Int);
            parm[0].Value = status;
            parm[1] = new SqlParameter("@EMP_ID", System.Data.SqlDbType.Int);
            parm[1].Value = empid;
            parm[2] = new SqlParameter("@Emp_Name", System.Data.SqlDbType.VarChar);
            parm[2].Value = empname;
            parm[3] = new SqlParameter("@Gender", System.Data.SqlDbType.VarChar);
            parm[3].Value = gender;
            parm[4] = new SqlParameter("@Age", System.Data.SqlDbType.Int);
            parm[4].Value = age;
            parm[5] = new SqlParameter("@Address1", System.Data.SqlDbType.VarChar);
            parm[5].Value = add;
            parm[6] = new SqlParameter("@Country", System.Data.SqlDbType.VarChar);
            parm[6].Value = country;
            parm[7] = new SqlParameter("@Phone_No", System.Data.SqlDbType.BigInt);
            parm[7].Value = phoneno;
            parm[8] = new SqlParameter("@Intrested", System.Data.SqlDbType.VarChar);
            parm[8].Value = intrested;
            int rowaff = SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, sp, parm);
            return rowaff;
        }
        public int Emp_upd(int status, int empid)
        {
            sp = "SP_HIMS_EMP_DETAILS";
            SqlParameter[] parm = new SqlParameter[1];
            parm[1] = new SqlParameter("@STATUS", System.Data.SqlDbType.Int);
            parm[1].Value = status;
            parm[2] = new SqlParameter("@EMP_ID", System.Data.SqlDbType.Int);
            parm[2].Value = DBNull.Value;
            int rowaff = SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, sp, parm);
            return rowaff;
        }
        public DataSet Select(int status)
        {
            sp = "SP_HIMS_EMP_DETAILS";
            SqlParameter[] parm = new SqlParameter[9];
            parm[0] = new SqlParameter("@STATUS", System.Data.SqlDbType.Int);
            parm[0].Value = status;
            parm[1] = new SqlParameter("@EMP_ID", System.Data.SqlDbType.Int);
            parm[1].Value = DBNull.Value;
            parm[2] = new SqlParameter("@Emp_Name", System.Data.SqlDbType.VarChar);
            parm[2].Value = DBNull.Value;
            parm[3] = new SqlParameter("@Gender", System.Data.SqlDbType.VarChar);
            parm[3].Value = DBNull.Value;
            parm[4] = new SqlParameter("@Age", System.Data.SqlDbType.Int);
            parm[4].Value = DBNull.Value;
            parm[5] = new SqlParameter("@Address1", System.Data.SqlDbType.VarChar);
            parm[5].Value = DBNull.Value;
            parm[6] = new SqlParameter("@Country", System.Data.SqlDbType.VarChar);
            parm[6].Value = DBNull.Value;
            parm[7] = new SqlParameter("@Phone_No", System.Data.SqlDbType.BigInt);
            parm[7].Value = DBNull.Value;
            parm[8] = new SqlParameter("@Intrested", System.Data.SqlDbType.VarChar);
            parm[8].Value = DBNull.Value;
            DataSet ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, sp, parm);
            return ds;
        }


    }
   
}