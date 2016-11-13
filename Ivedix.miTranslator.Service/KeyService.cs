using System.Collections.Generic;
using System.Linq;
using Ivedix.miTranslator.Data.Infrastructure;
using Ivedix.miTranslator.Data.Repositories;
using Ivedix.miTranslator.Model;

namespace Ivedix.miTranslator.Service
{
    public class KeyService : IKeyService
    {
        private readonly IKeyRepository keysRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public KeyService(IKeyRepository keysRepository, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.keysRepository = keysRepository;
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members

        public IEnumerable<Key> GetKeys()
        {
            var keys = keysRepository.GetAll();
            return keys;
        }

        public IEnumerable<Key> GetCategoryKeys(string categoryName, string keyName = null)
        {
            var category = categoryRepository.GetCategoryByName(categoryName);
            return category.Keys.Where(g => g.Name.ToLower().Contains(keyName.ToLower().Trim()));
        }

        public Key GetById(int id)
        {
            var key = keysRepository.GetById(id);
            return key;
        }

        public void CreateKey(Key key)
        {
            keysRepository.Add(key);
        }

        public void SaveKey()
        {
            unitOfWork.Commit();
        }

        #endregion



    }
}
