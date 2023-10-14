using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExpensesManagerV2
{
    public static class ConfigurationManager
    {
        /// <summary>
        /// Get the connection db string
        /// </summary>
        /// <returns></returns>
        public static string? GetConnectionString()
        {
            try
            {
                return XDocument.Load("AppConfig.xml")?
                    .Root?
                    .Elements("add")
                    .FirstOrDefault(e => e.Attribute("name")?.Value == "MyConnectionString")
                    ?.Attribute("connectionString")
                    ?.Value;
            }
            catch (Exception ex)
            {
                // Handle the exception or log it
                Console.WriteLine("Error reading connection string: " + ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }

}
