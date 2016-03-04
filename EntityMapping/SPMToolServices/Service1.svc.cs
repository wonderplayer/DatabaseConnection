using System.Collections.Generic;
using System.Linq;
using EntityMapping;
using SPMToolServices.DataContracts;

namespace SPMToolServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<ListInfo> GetLists()
        {
            var result = new List<ListInfo>();
            using (var context = new MyDbContext())
            {
                var lists = context.Lists.ToList();
                foreach(var list in lists)
                {
                    result.Add(new ListInfo {
                        Id = list.Id,
                        GUId = list.GUId,
                        InternalName = list.InternalName,
                        Name = list.Name,
                        URL = list.URL
                    });
                }
            }
            return result;
        }
    }
}
