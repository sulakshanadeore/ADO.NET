using Microsoft.Extensions.Configuration;
using System.Text.Json;

using Microsoft.Data.SqlClient;

namespace NorthwindUtil{
    public class DBPropertyUtil
    {

       static string cnstring= "Data Source=.\\sqlexpress;Initial Catalog=northwind;Integrated Security=True;Trust Server Certificate=True";
       
       

        public static SqlConnection GetConnectionString()
        {


            SqlConnection cn = new SqlConnection(cnstring);

            return cn;
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            //string path = AppDomain.CurrentDomain.BaseDirectory;
            // IConfigurationBuilder builder = new ConfigurationBuilder();
            // builder.SetBasePath(path);
            // IConfiguration configuration = builder.Build();
            //ConnectionString = configuration.GetConnectionString("NorthwindDB");

        }
    }
}
