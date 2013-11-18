using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Application.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBusinessService" in both code and config file together.
    [ServiceContract]
    public interface IBusinessService
    {
        [OperationContract]
        DataTable GetCarsByVendor(int vendorId);

        [OperationContract]
        SortedList<int, string> GetAllVendor();
    }
}
