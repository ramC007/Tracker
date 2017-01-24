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
    public class RegisterController : Controller
    {
        //
        // GET: /Register/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public string RegSave(Reg ObjReg)
        {
            Reg c = new Reg();
            c.FirstName = Convert.ToString(ObjReg.FirstName);
            c.LastName = Convert.ToString(ObjReg.LastName);
            c.Gender = Convert.ToString(ObjReg.Gender);
            c.DateOfBirth = Convert.ToString(ObjReg.DateOfBirth);
            c.Mobile = ObjReg.Mobile;
            c.Landline = (ObjReg.Landline);
            c.Street_1 = Convert.ToString(ObjReg.Street_1);
            c.Street_2 = Convert.ToString(ObjReg.Street_2);
            c.State = Convert.ToString(ObjReg.State);
            c.City = Convert.ToString(ObjReg.City);
            c.Country = Convert.ToString(ObjReg.Country);
            c.PinCode = ObjReg.PinCode;
            c.UserName = Convert.ToString(ObjReg.UserName);
            c.Email = Convert.ToString(ObjReg.Email);
            c.Password = Convert.ToString(ObjReg.Password);
            c.Re_Enter_Password = Convert.ToString(ObjReg.Re_Enter_Password);


            Service1 s = new Service1();
            return s.RegSave(c);

        }

    }
}
