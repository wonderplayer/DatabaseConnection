using System.Runtime.Serialization;

namespace SPMToolServices.DataContracts
{
    [DataContract]
    public class ItemInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public byte FieldId { get; set; }

        [DataMember]
        public int ItemId { get; set; }
    }
}