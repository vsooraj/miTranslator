
using System.Data.Entity.ModelConfiguration;
using Ivedix.miTranslator.Model;
namespace Ivedix.miTranslator.Data.Configuration
{
    public class KeyConfiguration : EntityTypeConfiguration<Key>
    {
        public KeyConfiguration()
        {
            ToTable("Keys");
            Property(g => g.Name).IsRequired().HasMaxLength(50);
            Property(g => g.Price).IsRequired().HasPrecision(8, 2);
            Property(g => g.CategoryID).IsRequired();
        }
    }
}
