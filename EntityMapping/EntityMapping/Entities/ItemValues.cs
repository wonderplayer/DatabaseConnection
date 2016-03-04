namespace EntityMapping.Entities
{
    public class ItemValues
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public byte FieldId { get; set; }
        
        public int ItemId { get; set; }

        public virtual Items Items { get; set; }

        public virtual Fields Fields { get; set; }
    }
}
