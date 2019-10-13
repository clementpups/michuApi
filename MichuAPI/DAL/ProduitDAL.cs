using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Elasticsearch.Net;
using MichuAPI.DAO;
using Nest;

namespace MichuAPI.DAL
{
    public partial class ProduitDAL
    {
        public ProduitDAL()a
        {

        }

        public Task<StringResponse> EnregistreeProduits(string jsonProduits, string nomIndex)
        {
            List<Produit> produits;
            produits = Produit.DeserialiserProduits(jsonProduits);
            ElasticLowLevelClient clientElastic = ConnexionElastic.GetClient();

            Task <StringResponse> responseIndex =  clientElastic.CreateAsync<StringResponse>(nomIndex, Guid.NewGuid().ToString(), PostData.Serializable(produits));
            return responseIndex;
        }
        
        public Task<List<Produit>> RecupererProduit(string nomIndex)
        {
            ElasticLowLevelClient clientElastic = ConnexionElastic.GetClient();

            var searchResponse = clientElastic.Search<StringResponse>(nomIndex, PostData.Serializable(new
            {
                query = new
                {
                    match = new
                    {
                        query = "match_all"
                   
                    }
                }
            });

        }

    }
}
