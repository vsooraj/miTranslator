using System.Collections.Generic;
using Ivedix.miTranslator.Model;

namespace Ivedix.miTranslator.Service
{
    // operations you want to expose
    public interface IKeyService
    {
        IEnumerable<Key> GetKeys();
        IEnumerable<Key> GetCategoryKeys(string categoryName, string keyName = null);
        Key GetById(int id);
        void CreateKey(Key key);
        void SaveKey();
    }
}
