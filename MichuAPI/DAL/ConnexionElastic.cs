using System;
namespace MichuAPI.DAL
{
    public class ConnexionElastic
    {
        public ConnexionElastic()
        {
        }

        public static Client GetClient(string NomIndex)
        {
            var node = new Uri("http://localhost:9200");

            var settings = new ConnectionSettings(
                node,
                defaultIndex: "my-application"
            );

            var client = new ElasticClient(settings);
        }
    }
}
