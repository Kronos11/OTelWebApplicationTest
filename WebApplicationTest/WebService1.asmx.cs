using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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

        [WebMethod]
        public string HelloWorld()
        {            
            const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;";
            using var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT TOP (1) * FROM [demo].[dbo].[table]";
                var result = cmd.ExecuteReader();
                return result.ToString(); 
            }
            catch (Exception e)
            {
                throw new ApplicationException("Unable to connect to SQLServer " + e);
            }            
        }
    }
}
