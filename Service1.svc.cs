using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tracker.Models;

namespace Tracker
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string Save(Class1 cc)
        {
            Bal b = new Bal();
            return b.Save(cc);

        }
        public string UserSave(Class1 cc)
        {
            Bal bb = new Bal();
            return bb.UserSave(cc);
        }
        public string LeaveSave(Class2 c)
        {
            Bal b = new Bal();
            return b.LeaveSave(c);
        }
        public string RegSave(Reg c)
        {
            Bal b = new Bal();
            return b.RegSave(c);
        }
    }
}
