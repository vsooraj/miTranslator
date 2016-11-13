using System.Data.Entity;
using Ivedix.miTranslator.Model;

namespace Ivedix.miTranslator.Data.Infrastructure
{
    public class TranslatorEntities : DbContext
    {
        public TranslatorEntities() : base("TranslatorEntities") { }

        public DbSet<Key> Keys { get; set; }
        public DbSet<Category> Categories { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Configurations.Add(new KeyConfiguration());
        //    modelBuilder.Configurations.Add(new CategoryConfiguration());
        //}
    }
}
