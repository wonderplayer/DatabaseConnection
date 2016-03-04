using EntityMapping.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Configurations
{
    public class ItemsConfiguration : EntityTypeConfiguration<Items>
    {
        public ItemsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Items");

            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SchemaXML).IsRequired().HasColumnName("SchemaXML").HasMaxLength(1000);
            Property(x => x.ListId).IsRequired().HasColumnName("ListId");

            HasRequired(i => i.Lists).WithMany(l => l.Items).HasForeignKey(i => i.ListId);
        }
    }
}
