namespace EntityMapping.Entities
{
    public class Items
    {
        public int Id { get; set; }

        public string SchemaXML { get; set; }

        public int ListId { get; set; }

        public virtual Lists Lists { get; set; }
    }
}
