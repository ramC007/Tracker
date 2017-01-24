using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace Tracker.Models
{
    public class Dal
    {

        public string connection = ("Data Source=LENOVO;Initial Catalog=DB_Allen;User ID=sa;password=dbadmin;");
        SqlConnection con = null;
        SqlCommand cmd = null;

        public string Save(Class1 cc)
        {
            using (con = new SqlConnection(connection))
            {
                con.Open();
                cmd = con.CreateCommand();
                using (cmd = new SqlCommand("sp_userdailyreport1", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@UserName", cc.UserName));
                    cmd.Parameters.Add(new SqlParameter("@Reporting_To", cc.Reporting_To));
                    cmd.Parameters.Add(new SqlParameter("@Date", cc.Date));
                    cmd.Parameters.Add(new SqlParameter("@FromTime", cc.FromTime));
                    cmd.Parameters.Add(new SqlParameter("@ToTime", cc.ToTime));
                    cmd.Parameters.Add(new SqlParameter("@discription", cc.discription));
                    cmd.Parameters.Add(new SqlParameter("@ReportID", cc.ReportID));

                    cmd.ExecuteNonQuery();

                    return "";

                }

            }
        }


        public string UserSave(Class1 cc )
        {
            using (con = new SqlConnection(connection))
            {
                con.Open();
                cmd = con.CreateCommand();
                using (cmd = new SqlCommand("sp_UserInfo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Name", cc.Name));
                    cmd.Parameters.Add(new SqlParameter("@Email", cc.Email));
                    cmd.Parameters.Add(new SqlParameter("@PhoneNumber", cc.PhoneNumber));
                    cmd.Parameters.Add(new SqlParameter("@JoinDate", cc.JoinDate));
                    cmd.Parameters.Add(new SqlParameter("@Gender", cc.Gender));
                
                    cmd.ExecuteNonQuery();

                    return "";

                }

            }
        }

        public string LeaveSave(Class2 c)
        {
            using (con = new SqlConnection(connection))
            {
                con.Open();
                cmd = con.CreateCommand();
                using (cmd = new SqlCommand("sp_LeaveRequest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", c.Name));
                    cmd.Parameters.Add(new SqlParameter("@Designation", c.Designation));
                    cmd.Parameters.Add(new SqlParameter("@Manager", c.Manager));
                    cmd.Parameters.Add(new SqlParameter("@LeaveType", c.LeaveType));
                    cmd.Parameters.Add(new SqlParameter("@FromDate", c.FromDate));
                    cmd.Parameters.Add(new SqlParameter("@ToDate", c.ToDate));
                    cmd.Parameters.Add(new SqlParameter("@NoOfDays", c.NoOfDays));
                    cmd.Parameters.Add(new SqlParameter("@LeaveDescription", c.LeaveDescription));
                    cmd.ExecuteNonQuery();
                    return "";
                }
            }
        }


        public string RegSave(Reg c)
        {
            using (con = new SqlConnection(connection))
            {
                con.Open();
                cmd = new SqlCommand();

                using (cmd = new SqlCommand("sp_c_registration", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FirstName", c.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", c.LastName));
                    cmd.Parameters.Add(new SqlParameter("@Gender", c.Gender));

                    cmd.Parameters.Add(new SqlParameter("@DateOfBirth", c.DateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@Mobile", c.Mobile));
                    cmd.Parameters.Add(new SqlParameter("@Landline", c.Landline));
                    cmd.Parameters.Add(new SqlParameter("@Street_1", c.Street_1));
                    cmd.Parameters.Add(new SqlParameter("@Street_2", c.Street_2));
                    cmd.Parameters.Add(new SqlParameter("@State", c.State));
                    cmd.Parameters.Add(new SqlParameter("@City", c.City));
                    cmd.Parameters.Add(new SqlParameter("@Country", c.Country));
                    cmd.Parameters.Add(new SqlParameter("@PinCode", c.PinCode));
                    cmd.Parameters.Add(new SqlParameter("@UserName", c.UserName));
                    cmd.Parameters.Add(new SqlParameter("@Email", c.Email));
                    cmd.Parameters.Add(new SqlParameter("@Password", c.Password));
                    cmd.Parameters.Add(new SqlParameter("@Re_Enter_Password", c.Re_Enter_Password));

                    cmd.ExecuteNonQuery();
                    return "";
                }
            }



        }

    }

}