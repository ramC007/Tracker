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
    public class LeaveController : Controller
    {
        public string connection = ("Data Source=LENOVO;Initial Catalog=DB_Allen;User ID=sa;password=dbadmin;");
        SqlConnection con = null;
        SqlCommand cmd = null;

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult LeaveRequest()
        {
            return View();
        }



        public List<LeaveGrid> Grid()
        {
            using (con = new SqlConnection(connection))
            {

                con.Open();
                cmd = con.CreateCommand();
                List<LeaveGrid> lst = new List<LeaveGrid>();
                using (cmd = new SqlCommand("sp_LeaveStatusGrid", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        LeaveGrid leaveStatus = new LeaveGrid();
                        leaveStatus.LeaveType = Convert.ToString(dr["LeaveType"]);
                        leaveStatus.FromPeriod = Convert.ToString(dr["FromPeriod"]);
                        leaveStatus.ToPeriod = Convert.ToString(dr["ToPeriod"]);
                        leaveStatus.Eligible = Convert.ToString(dr["Eligible"]);
                        leaveStatus.Available = Convert.ToString(dr["Available"]);
                        leaveStatus.Balance = Convert.ToString(dr["Balance"]);


                        lst.Add(leaveStatus);


                    }
                    dr.Close();
                }
                return lst;
            }


        }

        public ActionResult Grid2()
        {
            List<LeaveGrid> lst = new List<LeaveGrid>();

            var ss = Grid();
            var result = from s in ss select new[] { s.LeaveType.ToString(), s.FromPeriod.ToString(), s.ToPeriod.ToString(), s.Eligible.ToString(), s.Available.ToString(), s.Balance.ToString() };


            //var categories = (from category in allCategories
            //                  select category).ToList();
            return Json(new
            {

                aaData = result
            },
                JsonRequestBehavior.AllowGet
                );



        }

        public string LeaveSave(string Name, string Designation, string Manager, string LeaveType, string FromDate, string ToDate, string NoOfDays, string LeaveDescription)
        {
            Class2 c = new Class2();

            c.Name = Name;
            c.Designation = Designation;
            c.Manager = Manager;
            c.LeaveType = LeaveType;
            c.FromDate = FromDate;
            c.ToDate = ToDate;
            c.NoOfDays = NoOfDays;
            c.LeaveDescription = LeaveDescription;

            Service1 s = new Service1();
            return s.LeaveSave(c);
        }
    }
}
