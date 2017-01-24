using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tracker.Models;

namespace Tracker
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Save(Class1 cc);
        string UserSave(Class1 cc);
        string LeaveSave(Class2 c);
        string RegSave(Reg c);
    }
}
