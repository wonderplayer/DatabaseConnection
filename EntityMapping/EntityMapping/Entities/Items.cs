namespace EntityMapping.Entities
{
    public class Items
    {
        public int Id { get; set; }

        public string SchemaXML { get; set; }

        public short ListId { get; set; }

        public virtual Lists Lists { get; set; }
    }
}
