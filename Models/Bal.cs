using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Tracker.Models
{
    public class Bal
    {

        public string Save(Class1 cc)
        {
            Dal d = new Dal();
            return d.Save(cc);

        }

          public string UserSave(Class1 cc )
        {
            Dal dd = new Dal();
            return dd.UserSave(cc);
        }

        public string LeaveSave(Class2 c)
        {
             Dal d = new Dal();
            return d.LeaveSave(c);

        }
        public string RegSave(Reg c)
        {
            Dal d = new Dal();
            return d.RegSave(c);
        }
    }
}