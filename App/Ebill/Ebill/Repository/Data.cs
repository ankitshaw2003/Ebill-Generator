using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ebill.Models;
using Ebill.Repository;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ebill.Repository
{
    public class Data
    {
        //public string ConntionString { get; set; }
        //public Data()
        //{
        //    ConntionString = ConfigurationManager.ConnectionStrings[].ConnectionString;
        //}
        //public void SaveBillDetails(BillDetail details)
        //{
        //    SqlConnection con = new SqlConnection(ConntionString);
        //    try
        //    {\232
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("spt_saveEbillDetails", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
    }
}