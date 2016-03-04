using System.Collections.Generic;

namespace EntityMapping.Entities
{
    public class Fields
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public byte TypeId { get; set; }

        public short ListId { get; set; }

        public virtual Lists Lists { get; set; }

        public virtual FieldDataTypes Types { get; set; }

        public ICollection<ItemValues> ItemValues { get; set; }
    }
}
