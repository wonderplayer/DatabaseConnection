using EntityMapping.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Configurations
{
    public class FieldsConfiguration : EntityTypeConfiguration<Fields>
    {
        public FieldsConfiguration(string schema = "dbo")
        {
            ToTable(schema + "Fields");

            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).IsRequired().HasColumnName("Name").HasMaxLength(500);
            Property(x => x.ListId).IsRequired().HasColumnName("ListId");

            HasRequired(f => f.Lists).WithMany(l => l.Fields).HasForeignKey(f => f.Lists);
        }
    }
}
