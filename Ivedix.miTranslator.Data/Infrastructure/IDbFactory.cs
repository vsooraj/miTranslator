using System;

namespace Ivedix.miTranslator.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TranslatorEntities Init();
    }
}
