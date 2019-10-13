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

        public Task<IndexResponse> EnregistrerProduits(string jsonProduits, string nomIndex)
        {
            List<Produit> produits;
            produits = Produit.DeserialiserProduits(jsonProduits);
            ElasticClient clientElastic = ConnexionElastic.GetClient(nomIndex);

            Task <IndexResponse> responseIndex =  clientElastic.IndexDocumentAsync(produits);
            return responseIndex;
        }
        
        public Task<ISearchResponse<List<Produit>>> RecupererProduits(string nomIndex)
        {
            ElasticClient clientElastic = ConnexionElastic.GetClient(nomIndex);

            return clientElastic.SearchAsync<List<Produit>>(p => p
               .AllIndices()
               .From(0)
               .MatchAll());
        }

    }
}
