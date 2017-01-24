using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Tracker.Models;


namespace Tracker.Controllers
{
    public class HomeController : Controller
    {
        public string connection = ("Data Source=LENOVO;Initial Catalog=DB_Allen;User ID=sa;password=dbadmin;");
        SqlConnection con = null;
        SqlCommand cmd = null;


        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserReport()
        {
            return View();
        }
        public ActionResult WestUserReport()
        {
            return View();
        }
        public ActionResult Userdetail()
        {
            return View();

        }
        public ActionResult Admin()
        {
            return View();

        }

        public ActionResult LeaveRequest()
        {
            return View();
        }

  
/// <summary>
/// Created on 12-oct-2016 Allen Bert
/// </summary>
/// <returns></returns>


        public List<Class1> Ram()
        {
            using (con = new SqlConnection(connection))
            {
                con.Open();
                con.CreateCommand();
                List<Class1> lst = new List<Class1>();
                using (cmd = new SqlCommand("sp_Grid_UserReport", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Class1 cc = new Class1();

                        cc.ReportID = Convert.ToString(dr["ReportID"]);
                        cc.UserName = Convert.ToString(dr["UserName"]);
                        cc.Reporting_To = Convert.ToString(dr["Reporting_To"]);
                        cc.Date = Convert.ToString(dr["Date"]);
                        cc.FromTime = Convert.ToString(dr["FromTime"]);
                        cc.ToTime = Convert.ToString(dr["ToTime"]);
                        cc.discription = Convert.ToString(dr["discription"]);
                        




                        lst.Add(cc);
                    }
                    dr.Close();
                }
                return lst;
            }


        }



        public ActionResult grid()
        {

            List<Class1> lst = new List<Class1>();

            //  Today1408 objser = new Today1408();

            var ss = Ram();

            //var result = from s in ss select new[] { s.name, s.id.ToString() };
            var result = from s in ss select new[] { s.ReportID.ToString(), s.UserName, s.Reporting_To, s.Date, s.FromTime, s.ToTime, s.discription, "<img src='../image/delete.png' id='ImgDel' style='width:75px; height:30px;'/>" };

            return Json(new
            {
                aaData = result
            },
            JsonRequestBehavior.AllowGet);

        }




        public string Save(string UserName, string Reporting_TO, string Date, string From_Time, string TO_Time, string discription, string ReportID)
        {

            Class1 cc = new Class1();


            cc.UserName = UserName;
            cc.Reporting_To = Reporting_TO;
            cc.Date = Date;
            cc.FromTime = From_Time;
            cc.ToTime = TO_Time;
            cc.discription = discription;
            cc.ReportID = ReportID;

            Service1 s = new Service1();
            return s.Save(cc);

        }


        public string Dlt(Class1 obj)
        {
            obj.LogName = Convert.ToString("LogName");
            obj.Password = Convert.ToString("Password");


            Service1 ss = new Service1();
            return Dlt1(obj);



        }
        public string Dlt1(Class1 obj)
        {

            obj.LogName = Convert.ToString("LogName");
            obj.Password = Convert.ToString("Password");

            using (con = new SqlConnection(connection))
            {
                con.Open();
                cmd = con.CreateCommand();


                using (cmd = new SqlCommand("sp_ReportLogin", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("LogName", obj.LogName));
                    cmd.Parameters.Add(new SqlParameter("Password", obj.Password));

                    cmd.ExecuteNonQuery();
                    return "";


                }


            }


        }


        public object Password { get; set; }

        public object LogName { get; set; }


        //public string Delete(string ReportId)
        //{

        //    Service1 ss = new Service1();
        //    return DeleteGrid(ReportId);



        //}
        //public string DeleteGrid(string ReportId)
        //{



        //    using (con = new SqlConnection(connection))
        //    {
        //        con.Open();
        //        cmd = con.CreateCommand();


        //        using (cmd = new SqlCommand("sp_ReportDelete", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter("@ReportId", ReportId));
        //            cmd.ExecuteNonQuery();
        //            return "Deleted";


        //        }
        //    }


        //}
         
    
        public string Delete(string ReportID)
        {


            Service1 ss = new Service1();
            return Delete1(ReportID);



        }

        public string Delete1(string ReportID)
        {

            using (con = new SqlConnection(connection))
            {
                con.Open();
                cmd = con.CreateCommand();


                using (cmd = new SqlCommand("sp_reportdelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ReportID", ReportID));
                    cmd.ExecuteNonQuery();
                    return "Deleted";
                    
                }
            
            }


                


            }


        public string UserSave(string Name, string Email, string PhoneNumber, string JoinDate, string Gender)
        {

            Class1 cc = new Class1();


            cc.Name = Name;
            cc.Email = Email;
            cc.PhoneNumber = PhoneNumber;
            cc.JoinDate = JoinDate;
            cc.Gender = Gender;

            Service1 ss = new Service1();
            return ss.UserSave(cc);

        }


     }

      
    
}
