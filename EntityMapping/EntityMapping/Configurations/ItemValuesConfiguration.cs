using EntityMapping.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Configurations
{
    class ItemValuesConfiguration : EntityTypeConfiguration<ItemValues>
    {
        public ItemValuesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ItemValues");

            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Value).IsOptional().HasColumnName("Value").HasMaxLength(2000);
            Property(x => x.ItemId).IsRequired().HasColumnName("ItemId");
            Property(x => x.FieldId).IsRequired().HasColumnName("FieldId");

            HasRequired(iv => iv.Items).WithMany(i => i.Values).HasForeignKey(iv => iv.ItemId);
            HasRequired(iv => iv.Fields).WithMany(f => f.ItemValues).HasForeignKey(iv => iv.FieldId);
        }
    }
}
