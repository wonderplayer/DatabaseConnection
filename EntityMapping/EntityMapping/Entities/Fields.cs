namespace EntityMapping.Entities
{
    public class Fields
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public short ListId { get; set; }

        public virtual Lists Lists { get; set; }
    }
}
