using System.Runtime.Serialization;

namespace SPMToolServices.DataContracts
{
    [DataContract]
    public class ListInfo
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