using System.Collections.Generic;
using Ivedix.miTranslator.Model;


namespace Ivedix.miTranslator.Service
{
    // operations you want to expose
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories(string name = null);
        Category GetCategory(int id);
        Category GetCategory(string name);
        void CreateCategory(Category category);
        void SaveCategory();
    }
}
