using SPMToolServices.DataContracts;
using System.Collections.Generic;
using System.ServiceModel;

namespace SPMToolServices
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<ListInfo> GetLists();

        [OperationContract]
        List<ItemInfo> GetAllItems(string listName);
    }
}
