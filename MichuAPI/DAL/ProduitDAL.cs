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
        public ProduitDAL()
        {

        }

        public static Task<IndexResponse> EnregistrerProduits(string jsonProduits, string nomIndex)
        {
            List<Produit> produits;
            produits = Produit.DeserialiserProduits(jsonProduits);
            ElasticClient clientElastic = ConnexionElastic.GetClient(nomIndex);

            Task <IndexResponse> responseIndex =  clientElastic.IndexDocumentAsync(produits);
            return responseIndex;
        }
        
        public static Task<ISearchResponse<Produit>> RecupererProduits(string nomIndex)
        {
            ElasticClient clientElastic = ConnexionElastic.GetClient(nomIndex);

            return clientElastic.SearchAsync<Produit>(p => p
               .AllIndices()
               .From(0)
               .MatchAll());
        }

    }
}
