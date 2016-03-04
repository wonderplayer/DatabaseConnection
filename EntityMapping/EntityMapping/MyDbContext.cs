using EntityMapping.Configurations;
using EntityMapping.Entities;
using System.Data.Entity;

namespace EntityMapping
{
    public class MyDbContext : DbContext
    {
        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext() : base("Name=MyDbContext")
        {
        }

        public IDbSet<Lists> Lists { get; set; }

        public IDbSet<Fields> Fields { get; set; }

        public IDbSet<Items> Items { get; set; }

        public IDbSet<ItemValues> ItemValues { get; set; }

        public IDbSet<FieldDataTypes> FieldDataTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ListsConfiguration());
            modelBuilder.Configurations.Add(new FieldsConfiguration());
            modelBuilder.Configurations.Add(new ItemsConfiguration());
            modelBuilder.Configurations.Add(new ItemValuesConfiguration());
            modelBuilder.Configurations.Add(new FieldDataTypesConfiguration());
        }
    }
}
