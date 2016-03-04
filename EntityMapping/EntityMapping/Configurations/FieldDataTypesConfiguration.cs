using EntityMapping.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EntityMapping.Configurations
{
    class FieldDataTypesConfiguration : EntityTypeConfiguration<FieldDataTypes>
    {
        public FieldDataTypesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".FieldDataTypes");

            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Type).IsRequired().HasColumnName("Type").HasMaxLength(100);
        }
    }
}
