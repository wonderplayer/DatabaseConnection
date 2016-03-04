namespace EntityMapping.Entities
{
    public class Fields
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ListId { get; set; }

        public virtual Lists Lists { get; set; }
    }
}
