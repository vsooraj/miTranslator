using Ivedix.miTranslator.Data.Infrastructure;
using Ivedix.miTranslator.Model;

namespace Ivedix.miTranslator.Data.Repositories
{
    public class KeyRepository : RepositoryBase<Key>, IKeyRepository
    {
        public KeyRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

   
}
