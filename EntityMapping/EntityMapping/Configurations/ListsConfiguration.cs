using EntityMapping.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Configurations
{
    public class ListsConfiguration : EntityTypeConfiguration<Lists>
    {
        public ListsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Lists");

            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GUId).IsRequired().HasColumnName("GUId").HasMaxLength(50);
            Property(x => x.Name).IsRequired().HasColumnName("Name").HasMaxLength(1000);
            Property(x => x.InternalName).IsRequired().HasColumnName("InternalName").HasMaxLength(2000);
            Property(x => x.URL).IsRequired().HasColumnName("URL").HasMaxLength(2000);
        }
    }
}
