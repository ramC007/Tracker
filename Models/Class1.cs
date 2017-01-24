using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tracker.Models
{
    public class Class1
    {

        public string UserName { get; set; }
        public string Reporting_To { get; set; }
        public string Date { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string discription { get; set; }
        public string ReportID { get; set; }

        public string LogName { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string JoinDate { get; set; }
        public string Gender { get; set; }
      

        }
    public class Class2
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public string Manager { get; set; }
        public string LeaveType { get; set; }

        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string NoOfDays { get; set; }
        public string LeaveDescription { get; set; }
    }

    public class LeaveGrid
    {
        public string LeaveType { get; set; }
        public string FromPeriod { get; set; }
        public string ToPeriod { get; set; }
        public string Eligible { get; set; }
        public string Available { get; set; }
        public string Balance { get; set; }
    }

    public class Reg
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string Landline { get; set; }
        public string Street_1 { get; set; }
        public string Street_2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Re_Enter_Password { get; set; }


    }
}