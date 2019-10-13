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

        public static ElasticLowLevelClient GetClient()
        {
            ElasticLowLevelClient ElasticLowLevelClient = new ElasticLowLevelClient();

            ConnectionConfiguration settings = new ConnectionConfiguration(new Uri("http://example.com:9200"))
                    .RequestTimeout(TimeSpan.FromMilliseconds(250));
                    

            return new ElasticLowLevelClient(settings);
        }
    }
}
