using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ivedix.miTranslator.Data;
using Ivedix.miTranslator.Web.App_Start;

namespace Ivedix.miTranslator.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Init database
            System.Data.Entity.Database.SetInitializer(new TranslatorSeedData());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Autofac and Automapper configurations
            Bootstrapper.Run();
        }
    }
}
