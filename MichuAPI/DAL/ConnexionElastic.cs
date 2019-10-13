using Elasticsearch.Net;
using Nest;
using System;
namespace MichuAPI.DAL
{
    public class ConnexionElastic
    {
        private static string BaseElasticUri = @"https://michu-project-2576506609.eu-central-1.bonsaisearch.net:443/";

        public ConnexionElastic()
        {
        }

        public static ElasticClient GetClient(string nomIndex)
        {
            ConnectionSettings settings = new ConnectionSettings(new Uri(BaseElasticUri))
                    .DefaultIndex(nomIndex)
                    .RequestTimeout(TimeSpan.FromMilliseconds(250));

            return new ElasticClient(settings);
        }
    }
}
