
namespace Ivedix.miTranslator.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        TranslatorEntities dbContext;

        public TranslatorEntities Init()
        {
            return dbContext ?? (dbContext = new TranslatorEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
