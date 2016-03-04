using System.Collections.Generic;

namespace EntityMapping.Entities
{
    public class Items
    {
        public int Id { get; set; }

        public short ListId { get; set; }

        public virtual Lists Lists { get; set; }

        public ICollection<ItemValues> Values { get; set; }
    }
}
