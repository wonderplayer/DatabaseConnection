using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SPMToolServices.DataContracts
{
    [DataContract]
    public class GetLists
    {
        [DataMember]
        public short Id { get; set; }

        [DataMember]
        public string GUId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string InternalName { get; set; }

        [DataMember]
        public string URL { get; set; }
    }
}