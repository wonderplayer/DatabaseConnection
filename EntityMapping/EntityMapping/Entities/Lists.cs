using System.Collections.Generic;

namespace EntityMapping.Entities
{
    public class Lists
    {
        public int Id { get; set; }

        public string GUId { get; set; }

        public string Name { get; set; }

        public string InternalName { get; set; }

        public string URL { get; set; }

        public ICollection<Fields> Fields { get; set; }

        public ICollection<Items> Items { get; set; }
    }
}
