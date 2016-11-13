
using Ivedix.miTranslator.Data.Infrastructure;
using Ivedix.miTranslator.Model;
namespace Ivedix.miTranslator.Data.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string categoryName);
    }
}
