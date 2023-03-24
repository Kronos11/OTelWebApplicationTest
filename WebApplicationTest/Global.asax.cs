using Microsoft.Extensions.Logging;

namespace WebApplicationTest
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static ILogger Logger;
        protected void Application_Start()
        {
            var loggerFactory = new Microsoft.Extensions.Logging.LoggerFactory();
            Logger = loggerFactory.CreateLogger<WebApiApplication>();
        }
    }
}
