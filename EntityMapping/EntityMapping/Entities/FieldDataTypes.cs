using System.Collections.Generic;

namespace EntityMapping.Entities
{
    public class FieldDataTypes
    {
        public byte Id { get; set; }

        public string Type { get; set; }

        public ICollection<Fields> Fields { get; set; }
    }
}
