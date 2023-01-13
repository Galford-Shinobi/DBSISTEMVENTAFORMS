using System.Configuration;

namespace CapaDatos.Connections
{
    public class Connection
    {
        public static string DefaultConnections = ConfigurationManager.ConnectionStrings["BloggingContext"].ToString();
    }
}
