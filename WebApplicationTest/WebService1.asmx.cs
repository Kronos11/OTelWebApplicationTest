using System.Web.Services;
using System.Diagnostics;

namespace WebApplicationTest
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public static ActivitySource Source = new ActivitySource("ECDev.Activity");
       
        [WebMethod]
        public string HelloWorld()
        {
            using var activity = Source.StartActivity("Hello World");
            // do a thing
            activity?.AddEvent(new("Did a thing"));
            return "Hello World!";
        }
    }
}
